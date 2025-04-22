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
        
        try:
            # Get parcels from API
            local_logger.info("Requesting parcels from WMS API")
            parcels_data = api_client.get_parcels()
            
            if not parcels_data:
                local_logger.warning("API returned empty parcels data")
                return Response({"message": "No parcels found from API"})
            
            parcels_synced = 0
            # Process each parcel
            for parcel_data in parcels_data:
                try:
                    # Convert API model to Django model
                    parcel_id = parcel_data.get('id')
                    
                    if not parcel_id:
                        local_logger.warning(f"Skipping parcel without ID: {parcel_data}")
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
                    created_at = parcel_data.get('createdAt')
                    if created_at:
                        parsed_date = parse_iso_datetime(created_at)
                        if parsed_date:
                            parcel.created_at = parsed_date
                        else:
                            # Default to current time if we can't parse
                            parcel.created_at = timezone.now()
                    
                    parcel.waybill_number = parcel_data.get('waybillNumber')
                    parcel.qr_code = parcel_data.get('qrCode')
                    
                    dispatched_at = parcel_data.get('dispatchedAt')
                    if dispatched_at:
                        parsed_date = parse_iso_datetime(dispatched_at)
                        if parsed_date:
                            parcel.dispatched_at = parsed_date
                    
                    parcel.dispatch_tracking_code = parcel_data.get('dispatchTrackingCode')
                    parcel.sender = parcel_data.get('sender')
                    parcel.sender_telephone = parcel_data.get('senderTelephone')
                    parcel.receiver = parcel_data.get('receiver')
                    parcel.receiver_telephone = parcel_data.get('receiverTelephone')
                    parcel.destination = parcel_data.get('destination')
                    parcel.quantity = parcel_data.get('quantity', 0)
                    parcel.description = parcel_data.get('description', '')
                    parcel.amount = parcel_data.get('amount', 0)
                    parcel.rate = parcel_data.get('rate', 0)
                    parcel.payment_methods = parcel_data.get('paymentMethods', '')
                    parcel.total_amount = parcel_data.get('totalAmount', 0)
                    parcel.total_rate = parcel_data.get('totalRate', 0)
                    parcel.status = parcel_data.get('status', 0)
                    
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
        parcel = get_object_or_404(Parcel, id=parcel_id)
        return render(request, 'dispatch/parcel_detail.html', {'parcel': parcel})

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
        dispatch_parcels = DispatchParcel.objects.filter(dispatch=dispatch)
        
        context = {
            'dispatch': dispatch,
            'dispatch_parcels': dispatch_parcels,
            'print_view': True,
        }
        
        return render(request, 'dispatch/dispatch_note.html', context)

class CreateDispatchView(View):
    def get(self, request):
        # Get pending parcels
        pending_parcels = Parcel.objects.filter(status=ParcelStatus.PENDING)
        
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
            'is_admin': is_admin
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
                
                return render(request, 'dispatch/create_dispatch.html', {
                    'error': 'Destination and at least one parcel are required',
                    'pending_parcels': pending_parcels,
                    'available_destinations': available_destinations,
                    'user_branch': user_branch,
                    'is_admin': is_admin
                })
            
            # Check if manager is trying to dispatch to their own branch
            if is_manager and not is_admin and user_branch and destination == user_branch:
                all_destinations = Parcel.objects.values_list('destination', flat=True).distinct()
                available_destinations = [d for d in all_destinations if d != user_branch]
                
                pending_parcels = Parcel.objects.filter(status=ParcelStatus.PENDING)
                if is_manager and not is_admin and user_branch:
                    pending_parcels = pending_parcels.filter(destination=user_branch)
                
                return render(request, 'dispatch/create_dispatch.html', {
                    'error': f'As a branch manager for {user_branch}, you cannot dispatch to your own branch',
                    'pending_parcels': pending_parcels,
                    'available_destinations': available_destinations,
                    'user_branch': user_branch,
                    'is_admin': is_admin
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
                            
                            return render(request, 'dispatch/create_dispatch.html', {
                                'error': f'You can only dispatch parcels from your branch ({user_branch})',
                                'pending_parcels': pending_parcels,
                                'available_destinations': available_destinations,
                                'user_branch': user_branch,
                                'is_admin': is_admin
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
                
            return render(request, 'dispatch/create_dispatch.html', {
                'error': f'Error creating dispatch: {str(e)}',
                'pending_parcels': pending_parcels,
                'available_destinations': available_destinations,
                'user_branch': user_branch,
                'is_admin': is_admin
            })
