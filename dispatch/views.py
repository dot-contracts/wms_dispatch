from django.shortcuts import render, get_object_or_404, redirect
from django.http import HttpResponse, JsonResponse
from django.views import View
from django.db.models import Sum, Count
from django.utils import timezone
from rest_framework import viewsets, status
from rest_framework.response import Response
from rest_framework.decorators import action
from datetime import datetime
import uuid
import random
import string
import logging
from django.contrib import messages
from django.contrib.auth.mixins import LoginRequiredMixin
from django.contrib.auth import authenticate, login, logout
from django.contrib.auth.decorators import login_required
from django.utils.decorators import method_decorator
import re
from django.conf import settings
import json
from decimal import Decimal, InvalidOperation
import requests

from .models import Parcel, Dispatch, DispatchParcel, ParcelStatus
from .serializers import ParcelSerializer, DispatchSerializer, DispatchCreateSerializer
from .api_client import WmsApiClient

# Set up logger
logger = logging.getLogger(__name__)

# Authentication views
def login_view(request):
    """Login view that authenticates against the EMS database"""
    if request.method == 'POST':
        username = request.POST.get('username')
        password = request.POST.get('password')
        
        if not username or not password:
            messages.error(request, 'Please provide both username and password.')
            return render(request, 'dispatch/login.html')
            
        # Authenticate using our custom backend
        user = authenticate(request, username=username, password=password)
        
        if user is not None:
            login(request, user)
            messages.success(request, f'Welcome, {user.first_name or user.username}!')
            
            # Redirect to the page they were trying to access, or dashboard
            next_url = request.GET.get('next', 'dashboard')
            return redirect(next_url)
        else:
            messages.error(request, 'Invalid username or password.')
            
    return render(request, 'dispatch/login.html')

@login_required
def logout_view(request):
    """Logout view"""
    logout(request)
    messages.info(request, 'You have been logged out.')
    return redirect('login')

def parse_iso_datetime(datetime_str):
    """
    Parse ISO format datetime strings with proper handling of timezone info
    """
    try:
        # Handle format "2025-02-25T16:01:56.416586+03:00"
        if '+' in datetime_str:
            # Fix microseconds precision
            pattern = r'(\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2})\.(\d+)(\+\d{2}:\d{2})'
            match = re.match(pattern, datetime_str)
            if match:
                dt_part = match.group(1)
                micro_part = match.group(2)[:6]  # Truncate to max 6 digits
                tz_part = match.group(3)
                
                # Pad microseconds with zeros if needed
                micro_part = micro_part.ljust(6, '0')
                datetime_str = f"{dt_part}.{micro_part}{tz_part}"
                
            return datetime.fromisoformat(datetime_str)
        elif 'Z' in datetime_str:
            # Handle UTC "Z" timezone indicator
            return datetime.fromisoformat(datetime_str.replace('Z', '+00:00'))
        else:
            # No timezone info, parse as is
            return datetime.fromisoformat(datetime_str)
    except ValueError as e:
        logger.warning(f"Could not parse ISO datetime: {datetime_str}, error: {str(e)}")
        # Try simpler date formats as fallback
        try:
            # Try just the date part
            if 'T' in datetime_str:
                return datetime.strptime(datetime_str.split('T')[0], '%Y-%m-%d')
            else:
                return datetime.strptime(datetime_str, '%Y-%m-%d')
        except ValueError:
            logger.error(f"Failed to parse date in any format: {datetime_str}")
            return None

# API Views
class ParcelViewSet(viewsets.ModelViewSet):
    queryset = Parcel.objects.all()
    serializer_class = ParcelSerializer
    
    @action(detail=False, methods=['get'])
    def pending(self, request):
        parcels = Parcel.objects.filter(status=ParcelStatus.PENDING)
        
        # Filter by user's branch if they are a branch manager but not an admin
        user_roles = request.session.get('user_roles', [])
        user_branch = request.session.get('user_branch')
        
        is_admin = 'Admin' in user_roles
        is_manager = 'Manager' in user_roles
        
        # Only filter by branch if user is a manager but not an admin
        if is_manager and not is_admin and user_branch:
            parcels = parcels.filter(destination=user_branch)
        
        serializer = self.get_serializer(parcels, many=True)
        return Response(serializer.data)
    
    @action(detail=False, methods=['get'])
    def sync_from_api(self, request):
        """Sync parcels from the WMS API"""
        # Ensure logger is available
        local_logger = logging.getLogger(__name__)
        local_logger.info("Starting sync_from_api operation")
        api_client = WmsApiClient()

        # Helper function to parse decimal fields safely
        def parse_decimal_field(value_from_api, field_name_for_log, default_decimal_str='0.00'):
            if value_from_api is None:
                return Decimal(default_decimal_str)
            try:
                # Convert to string first to handle potential floats/ints robustly before Decimal
                return Decimal(str(value_from_api))
            except InvalidOperation:
                local_logger.warning(f"Invalid value for decimal field '{field_name_for_log}': {value_from_api}. Using default {default_decimal_str}.")
                return Decimal(default_decimal_str)
        
        try:
            # Get parcels from API
            local_logger.info("Requesting parcels from WMS API")
            parcels_data = api_client.get_parcels()
            
            if not parcels_data:
                local_logger.warning("API returned empty parcels data")
                return Response({"message": "No parcels found from API"})
            
            parcels_synced = 0
            # Process each parcel
            for parcel_dict in parcels_data:
                try:
                    if not isinstance(parcel_dict, dict):
                        local_logger.warning(f"Skipping non-dictionary item in parcels_data: {type(parcel_dict)} - Data: {str(parcel_dict)[:200]}")
                        continue

                    # Convert API model to Django model using parcel_dict
                    parcel_id = parcel_dict.get('id')
                    
                    if not parcel_id:
                        local_logger.warning(f"Skipping parcel without ID: {parcel_dict}")
                        continue
                    
                    # Try to find existing parcel
                    try:
                        parcel = Parcel.objects.get(id=parcel_id)
                        local_logger.debug(f"Updating existing parcel: {parcel_id}")
                    except Parcel.DoesNotExist:
                        # Create a new parcel
                        parcel = Parcel(id=parcel_id)
                        local_logger.debug(f"Creating new parcel: {parcel_id}")
                    
                    # Update parcel fields
                    created_at = parcel_dict.get('createdAt')
                    if created_at:
                        parsed_date = parse_iso_datetime(created_at)
                        if parsed_date:
                            parcel.created_at = parsed_date
                        else:
                            # Default to current time if we can't parse
                            parcel.created_at = timezone.now()
                    
                    parcel.waybill_number = parcel_dict.get('waybillNumber')
                    parcel.qr_code = parcel_dict.get('qrCode')
                    
                    dispatched_at = parcel_dict.get('dispatchedAt')
                    if dispatched_at:
                        parsed_date = parse_iso_datetime(dispatched_at)
                        if parsed_date:
                            parcel.dispatched_at = parsed_date
                    
                    parcel.dispatch_tracking_code = parcel_dict.get('dispatchTrackingCode')
                    parcel.sender = parcel_dict.get('sender')
                    parcel.sender_telephone = parcel_dict.get('senderTelephone')
                    parcel.receiver = parcel_dict.get('receiver')
                    parcel.receiver_telephone = parcel_dict.get('receiverTelephone')
                    parcel.destination = parcel_dict.get('destination')
                    
                    # Explicitly set payment_methods (ensure correct key from API response)
                    parcel.payment_methods = parcel_dict.get('paymentMethods', '') # Use default of empty string if not present

                    # Handle quantity (model default is 1, ensure it's an int)
                    api_quantity = parcel_dict.get('quantity')
                    if api_quantity is not None:
                        try:
                            parcel.quantity = int(api_quantity)
                        except (ValueError, TypeError):
                            local_logger.warning(f"Invalid quantity value from API: {api_quantity} for parcel {parcel_id}. Defaulting to 1.")
                            parcel.quantity = 1 # Default from model if conversion fails
                    else:
                        parcel.quantity = 1 # Default from model

                    parcel.description = parcel_dict.get('description', '')
                    
                    # Handle monetary fields (ensure they are Decimals and not None)
                    parcel.amount = parse_decimal_field(parcel_dict.get('amount'), 'amount')
                    parcel.rate = parse_decimal_field(parcel_dict.get('rate'), 'rate')
                    parcel.total_amount = parse_decimal_field(parcel_dict.get('totalAmount'), 'totalAmount')
                    parcel.total_rate = parse_decimal_field(parcel_dict.get('totalRate'), 'totalRate')
                    
                    # Handle status (model default is ParcelStatus.PENDING (0))
                    api_status = parcel_dict.get('status')
                    if api_status is not None:
                        try:
                            parcel.status = int(api_status)
                        except (ValueError, TypeError):
                            local_logger.warning(f"Invalid status value from API: {api_status} for parcel {parcel_id}. Defaulting to PENDING.")
                            parcel.status = ParcelStatus.PENDING
                    else:
                        parcel.status = ParcelStatus.PENDING
                    
                    parcel.save()
                    parcels_synced += 1
                    
                except Exception as parcel_error:
                    local_logger.error(f"Error processing parcel: {str(parcel_error)}")
                    # Continue with next parcel instead of failing entire sync
                    continue
            
            local_logger.info(f"Sync completed successfully. Synced {parcels_synced} parcels.")
            return Response({"message": f"Synced {parcels_synced} parcels successfully"})
            
        except Exception as e:
            local_logger.error(f"Sync failed: {str(e)}")
            return Response({"error": str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)

class DispatchViewSet(viewsets.ModelViewSet):
    queryset = Dispatch.objects.all()
    
    def get_serializer_class(self):
        if self.action in ['create', 'update', 'partial_update']:
            return DispatchCreateSerializer
        return DispatchSerializer
    
    def perform_create(self, serializer):
        # Generate a dispatch code if not provided
        if not serializer.validated_data.get('dispatch_code'):
            today = timezone.now().strftime('%Y%m%d')
            random_chars = ''.join(random.choices(string.ascii_uppercase + string.digits, k=4))
            dispatch_code = f"DSP-{today}-{random_chars}"
            serializer.save(dispatch_code=dispatch_code)
        else:
            serializer.save()

# Web Views
class DashboardView(View):
    def get(self, request):
        total_parcels = Parcel.objects.count()
        pending_parcels = Parcel.objects.filter(status=ParcelStatus.PENDING).count()
        in_transit_parcels = Parcel.objects.filter(status=ParcelStatus.IN_TRANSIT).count()
        delivered_parcels = Parcel.objects.filter(status=ParcelStatus.DELIVERED).count()
        
        dispatches = Dispatch.objects.all().order_by('-dispatch_date')[:5]
        
        recent_parcels = Parcel.objects.all().order_by('-created_at')[:10]
        
        context = {
            'total_parcels': total_parcels,
            'pending_parcels': pending_parcels,
            'in_transit_parcels': in_transit_parcels,
            'delivered_parcels': delivered_parcels,
            'dispatches': dispatches,
            'recent_parcels': recent_parcels,
        }
        
        return render(request, 'dispatch/dashboard.html', context)

class ParcelListView(View):
    def get(self, request):
        # Start with all parcels
        parcels_query = Parcel.objects.all()
        
        # If user is a branch manager (not admin), filter by destination
        user_roles = request.session.get('user_roles', [])
        user_branch = request.session.get('user_branch')
        
        is_admin = 'Admin' in user_roles
        is_manager = 'Manager' in user_roles
        
        # Show branch-specific filtering message
        branch_filter_active = False
        
        # Only filter by branch if user is a manager but not an admin
        if is_manager and not is_admin and user_branch:
            parcels_query = parcels_query.filter(destination=user_branch)
            branch_filter_active = True
        
        # Status filter
        status_filter = request.GET.get('status', None)
        if status_filter and status_filter.isdigit():
            parcels_query = parcels_query.filter(status=int(status_filter))
        
        # Date filter
        date_filter = request.GET.get('date', None)
        if date_filter:
            try:
                # Parse the date from the filter
                filter_date = datetime.strptime(date_filter, '%Y-%m-%d').date()
                
                # Use __date to compare just the date part of created_at
                # This works regardless of the timezone stored in the database
                parcels_query = parcels_query.filter(created_at__date=filter_date)
                
            except ValueError:
                # Invalid date format, ignore filter
                pass
        
        # Destination filter
        destination_filter = request.GET.get('destination', None)
        if destination_filter:
            parcels_query = parcels_query.filter(destination=destination_filter)
        
        # Payment mode filter
        payment_mode_filter = request.GET.get('payment_mode', None)
        if payment_mode_filter:
            parcels_query = parcels_query.filter(payment_methods=payment_mode_filter)
        
        # Get available destinations and payment methods for filter dropdowns
        destinations = Parcel.objects.values_list('destination', flat=True).distinct()
        payment_methods = Parcel.objects.values_list('payment_methods', flat=True).distinct()
        
        context = {
            'parcels': parcels_query,
            'status_filter': status_filter,
            'date_filter': date_filter,
            'destination_filter': destination_filter,
            'payment_mode_filter': payment_mode_filter,
            'status_choices': ParcelStatus.choices,
            'destinations': destinations,
            'payment_methods': payment_methods,
            'branch_filter_active': branch_filter_active,
            'user_branch': user_branch,
            'is_admin': is_admin,
        }
        
        return render(request, 'dispatch/parcel_list.html', context)

class ParcelDetailView(View):
    def get(self, request, parcel_id):
        api_client = WmsApiClient()
        parcel_data = None
        error_message = None

        try:
            parcel_data = api_client.get_parcel_by_id(parcel_id)
            logger.info(f"[ParcelDetailView] Successfully fetched parcel ID {parcel_id} from API.")

            if parcel_data:
                # Handle createdAt
                created_at_val = parcel_data.get('createdAt')
                if created_at_val:
                    dt_obj = parse_iso_datetime(str(created_at_val)) # Ensure it's a string for parser
                    if dt_obj:
                        if not timezone.is_aware(dt_obj):
                            # If naive, assume it's UTC and make it aware
                            dt_obj = timezone.make_aware(dt_obj, timezone.utc)
                        parcel_data['createdAt'] = timezone.localtime(dt_obj) # Convert to local time
                    else:
                        parcel_data['createdAt'] = None # Parsing failed
                
                # Handle dispatchedAt
                dispatched_at_val = parcel_data.get('dispatchedAt')
                if dispatched_at_val:
                    dt_obj = parse_iso_datetime(str(dispatched_at_val))
                    if dt_obj:
                        if not timezone.is_aware(dt_obj):
                            dt_obj = timezone.make_aware(dt_obj, timezone.utc)
                        parcel_data['dispatchedAt'] = timezone.localtime(dt_obj)
                    else:
                        parcel_data['dispatchedAt'] = None

        except requests.exceptions.HTTPError as e:
            # Handle HTTP errors (like 404 Not Found, 500 Internal Server Error from API)
            logger.error(f"[ParcelDetailView] API HTTPError for parcel ID {parcel_id}: {e.response.status_code} - {e.response.text}")
            if e.response.status_code == 404:
                error_message = "Parcel not found in the remote system."
            else:
                error_message = f"Error fetching parcel from API: Status {e.response.status_code}"
        except requests.exceptions.RequestException as e:
            # Handle other network-related errors (e.g., connection timeout)
            logger.error(f"[ParcelDetailView] API RequestException for parcel ID {parcel_id}: {str(e)}")
            error_message = "Could not connect to the parcel service. Please try again later."
        except json.JSONDecodeError as e:
            # Handle errors if the API response is not valid JSON
            logger.error(f"[ParcelDetailView] API JSONDecodeError for parcel ID {parcel_id}: {str(e)}")
            error_message = "Received an invalid response from the parcel service."
        except Exception as e:
            # Catch any other unexpected errors from the API client or processing
            logger.error(f"[ParcelDetailView] Unexpected error fetching parcel ID {parcel_id} from API: {str(e)}")
            error_message = "An unexpected error occurred while retrieving parcel details."

        # For the template, pass the parcel_data dictionary or None if an error occurred
        # The template will need to be updated to handle this dictionary directly
        # and also to display error_message if present.
        context = {
            'parcel_dict': parcel_data, # Renamed to avoid clash if 'parcel' object was expected
            'error_message': error_message,
            # We might need to pass the parcel_id itself if error_message is shown
            # and we want to refer to the ID that failed.
            'requested_parcel_id': parcel_id 
        }
        return render(request, 'dispatch/parcel_detail.html', context)

class ConsignmentNoteView(View):
    def get(self, request, parcel_id):
        parcel = get_object_or_404(Parcel, id=parcel_id)
        return render(request, 'dispatch/consignment_note.html', {'parcel': parcel})

class DispatchListView(View):
    def get(self, request):
        dispatches = Dispatch.objects.all().order_by('-dispatch_date')
        return render(request, 'dispatch/dispatch_list.html', {'dispatches': dispatches})

class DispatchDetailView(View):
    def get(self, request, dispatch_id):
        dispatch = get_object_or_404(Dispatch, id=dispatch_id)
        dispatch_parcels = DispatchParcel.objects.filter(dispatch=dispatch)
        
        context = {
            'dispatch': dispatch,
            'dispatch_parcels': dispatch_parcels,
        }
        
        return render(request, 'dispatch/dispatch_detail.html', context)

class DispatchNoteView(View):
    def get(self, request, dispatch_id):
        dispatch = get_object_or_404(Dispatch, id=dispatch_id)
        dispatch_parcels = DispatchParcel.objects.filter(dispatch=dispatch).select_related('parcel') # Eager load related parcel

        total_cod_amount = Decimal('0.00')
        total_paid_amount = Decimal('0.00')
        total_contract_amount = Decimal('0.00')
        overall_total_amount = Decimal('0.00') # This should match dispatch.total_amount ideally

        for dp in dispatch_parcels:
            actual_parcel = dp.parcel # Access the related Parcel instance
            amount_to_add = actual_parcel.total_amount if actual_parcel.total_amount is not None else Decimal('0.00')
            overall_total_amount += amount_to_add

            # Ensure payment_methods is a string before calling lower()
            payment_method_str = str(actual_parcel.payment_methods).lower() if actual_parcel.payment_methods else ""

            if payment_method_str == 'cod': # Assuming 'cod' is the stored value
                total_cod_amount += amount_to_add
            elif payment_method_str == 'paid': # Assuming 'paid' is the stored value
                total_paid_amount += amount_to_add
            elif payment_method_str == 'contract': # Assuming 'contract' is the stored value
                total_contract_amount += amount_to_add
            # else: consider if other payment methods should be summed or handled distinctly
        
        context = {
            'dispatch': dispatch,
            'dispatch_parcels': dispatch_parcels,
            'print_view': True,
            'total_cod_amount': total_cod_amount,
            'total_paid_amount': total_paid_amount,
            'total_contract_amount': total_contract_amount,
            'calculated_overall_total': overall_total_amount # For verification, can be removed later
        }
        
        return render(request, 'dispatch/dispatch_note.html', context)

class CreateDispatchView(View):
    def get(self, request):
        # Get pending parcels
        pending_parcels = Parcel.objects.filter(status=ParcelStatus.PENDING)
        date_filter_str = request.GET.get('date_filter', '') # Get date_filter string
        filter_date_obj = None

        if date_filter_str:
            try:
                filter_date_obj = datetime.strptime(date_filter_str, '%Y-%m-%d').date()
                pending_parcels = pending_parcels.filter(created_at__date=filter_date_obj)
            except ValueError:
                # Handle invalid date format if necessary, e.g., show a message or log
                # For now, we'll just ignore it, and no date filter will be applied
                pass # Or messages.warning(request, "Invalid date format for filter.")
        
        # Get user role and branch information
        user_roles = request.session.get('user_roles', [])
        user_branch = request.session.get('user_branch')
        
        is_admin = 'Admin' in user_roles
        is_manager = 'Manager' in user_roles
        
        # If user is a branch manager but not an admin, only show parcels for their branch
        if is_manager and not is_admin and user_branch:
            pending_parcels = pending_parcels.filter(destination=user_branch)
        
        # Get unique destinations from parcels
        all_destinations = Parcel.objects.values_list('destination', flat=True).distinct()
        
        # If user is a manager but not admin, exclude their own branch from destinations
        available_destinations = list(all_destinations)
        if is_manager and not is_admin and user_branch:
            available_destinations = [d for d in all_destinations if d != user_branch]
        
        return render(request, 'dispatch/create_dispatch.html', {
            'pending_parcels': pending_parcels,
            'available_destinations': available_destinations,
            'user_branch': user_branch,
            'is_admin': is_admin,
            'date_filter_value': date_filter_str # Pass the string back to the template
        })
    
    def post(self, request):
        try:
            destination = request.POST.get('destination')
            parcel_ids = request.POST.getlist('parcel_ids')
            vehicle_registration = request.POST.get('vehicle_registration', '')
            driver_name = request.POST.get('driver_name', '')
            
            # Check user's role and branch information
            user_roles = request.session.get('user_roles', [])
            user_branch = request.session.get('user_branch')
            
            is_admin = 'Admin' in user_roles
            is_manager = 'Manager' in user_roles
            
            # Validate destination and parcel IDs
            if not destination or not parcel_ids:
                all_destinations = Parcel.objects.values_list('destination', flat=True).distinct()
                available_destinations = list(all_destinations)
                if is_manager and not is_admin and user_branch:
                    available_destinations = [d for d in all_destinations if d != user_branch]
                
                pending_parcels = Parcel.objects.filter(status=ParcelStatus.PENDING)
                if is_manager and not is_admin and user_branch:
                    pending_parcels = pending_parcels.filter(destination=user_branch)
                # Re-apply date filter if it was active, so error page still shows filtered list
                date_filter_str_post = request.POST.get('date_filter_for_post', request.GET.get('date_filter', ''))
                if date_filter_str_post:
                    try:
                        filter_date_obj_post = datetime.strptime(date_filter_str_post, '%Y-%m-%d').date()
                        pending_parcels = pending_parcels.filter(created_at__date=filter_date_obj_post)
                    except ValueError:
                        pass
                
                return render(request, 'dispatch/create_dispatch.html', {
                    'error': 'Destination and at least one parcel are required',
                    'pending_parcels': pending_parcels,
                    'available_destinations': available_destinations,
                    'user_branch': user_branch,
                    'is_admin': is_admin,
                    'date_filter_value': date_filter_str_post
                })
            
            # Check if manager is trying to dispatch to their own branch
            if is_manager and not is_admin and user_branch and destination == user_branch:
                all_destinations = Parcel.objects.values_list('destination', flat=True).distinct()
                available_destinations = [d for d in all_destinations if d != user_branch]
                
                pending_parcels = Parcel.objects.filter(status=ParcelStatus.PENDING)
                if is_manager and not is_admin and user_branch:
                    pending_parcels = pending_parcels.filter(destination=user_branch)
                # Re-apply date filter
                date_filter_str_post = request.POST.get('date_filter_for_post', request.GET.get('date_filter', ''))
                if date_filter_str_post:
                    try:
                        filter_date_obj_post = datetime.strptime(date_filter_str_post, '%Y-%m-%d').date()
                        pending_parcels = pending_parcels.filter(created_at__date=filter_date_obj_post)
                    except ValueError:
                        pass
                
                return render(request, 'dispatch/create_dispatch.html', {
                    'error': f'As a branch manager for {user_branch}, you cannot dispatch to your own branch',
                    'pending_parcels': pending_parcels,
                    'available_destinations': available_destinations,
                    'user_branch': user_branch,
                    'is_admin': is_admin,
                    'date_filter_value': date_filter_str_post
                })
            
            # Validate that a branch manager is only dispatching parcels from their branch
            if is_manager and not is_admin and user_branch:
                # Check each parcel to ensure it belongs to manager's branch
                for parcel_id in parcel_ids:
                    try:
                        parcel = Parcel.objects.get(id=parcel_id)
                        if parcel.destination != user_branch:
                            all_destinations = Parcel.objects.values_list('destination', flat=True).distinct()
                            available_destinations = [d for d in all_destinations if d != user_branch]
                            
                            pending_parcels = Parcel.objects.filter(status=ParcelStatus.PENDING, destination=user_branch)
                            # Re-apply date filter
                            date_filter_str_post = request.POST.get('date_filter_for_post', request.GET.get('date_filter', ''))
                            if date_filter_str_post:
                                try:
                                    filter_date_obj_post = datetime.strptime(date_filter_str_post, '%Y-%m-%d').date()
                                    pending_parcels = pending_parcels.filter(created_at__date=filter_date_obj_post)
                                except ValueError:
                                    pass
                            
                            return render(request, 'dispatch/create_dispatch.html', {
                                'error': f'You can only dispatch parcels from your branch ({user_branch})',
                                'pending_parcels': pending_parcels,
                                'available_destinations': available_destinations,
                                'user_branch': user_branch,
                                'is_admin': is_admin,
                                'date_filter_value': date_filter_str_post
                            })
                    except Parcel.DoesNotExist:
                        pass
            
            # Generate dispatch code
            today = timezone.now().strftime('%Y%m%d')
            random_chars = ''.join(random.choices(string.ascii_uppercase + string.digits, k=4))
            dispatch_code = f"DSP-{today}-{random_chars}"
            
            # Create dispatch
            dispatch = Dispatch.objects.create(
                destination=destination,
                dispatch_code=dispatch_code,
                vehicle_registration=vehicle_registration,
                driver_name=driver_name,
                status=ParcelStatus.IN_TRANSIT
            )
            
            total_parcels = 0
            total_amount = 0
            
            # Add parcels to dispatch
            for parcel_id in parcel_ids:
                try:
                    parcel = Parcel.objects.get(id=parcel_id)
                    
                    # Double-check parcel belongs to manager's branch if they're a manager
                    if is_manager and not is_admin and user_branch and parcel.destination != user_branch:
                        continue
                    
                    DispatchParcel.objects.create(dispatch=dispatch, parcel=parcel)
                    
                    # Update parcel status
                    parcel.status = ParcelStatus.IN_TRANSIT
                    parcel.dispatch_tracking_code = dispatch_code
                    parcel.dispatched_at = timezone.now()
                    parcel.save()
                    
                    total_parcels += 1
                    total_amount += parcel.total_amount
                except Parcel.DoesNotExist:
                    pass
            
            # Update dispatch totals
            dispatch.total_parcels = total_parcels
            dispatch.total_amount = total_amount
            dispatch.save()
            
            messages.success(request, f'Successfully created dispatch {dispatch_code} to {destination}')
            return redirect('dispatch_detail', dispatch_id=dispatch.id)
            
        except Exception as e:
            all_destinations = Parcel.objects.values_list('destination', flat=True).distinct()
            available_destinations = list(all_destinations)
            if is_manager and not is_admin and user_branch:
                available_destinations = [d for d in all_destinations if d != user_branch]
                
            pending_parcels = Parcel.objects.filter(status=ParcelStatus.PENDING)
            if is_manager and not is_admin and user_branch:
                pending_parcels = pending_parcels.filter(destination=user_branch)
            # Re-apply date filter
            date_filter_str_post = request.POST.get('date_filter_for_post', request.GET.get('date_filter', ''))
            if date_filter_str_post:
                try:
                    filter_date_obj_post = datetime.strptime(date_filter_str_post, '%Y-%m-%d').date()
                    pending_parcels = pending_parcels.filter(created_at__date=filter_date_obj_post)
                except ValueError:
                    pass
                
            return render(request, 'dispatch/create_dispatch.html', {
                'error': f'Error creating dispatch: {str(e)}',
                'pending_parcels': pending_parcels,
                'available_destinations': available_destinations,
                'user_branch': user_branch,
                'is_admin': is_admin,
                'date_filter_value': date_filter_str_post
            })
