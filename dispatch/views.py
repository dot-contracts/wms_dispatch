from django.shortcuts import render, redirect
from django.http import HttpResponse, JsonResponse
from django.views import View
from django.utils import timezone
from rest_framework import viewsets, status
from rest_framework.response import Response
from rest_framework.decorators import action
from datetime import datetime
import logging
from django.contrib import messages
from django.utils.decorators import method_decorator
import re
from django.conf import settings
import json
from decimal import Decimal, InvalidOperation
import uuid
import requests

from .models import Branch, UserProfile, ContractCustomer, Invoice, InvoiceItem
from .api_client import WmsApiClient
from .auth_backend import ApiAuthenticationBackend
from .middleware import login_user, logout_user, login_required_api, is_authenticated
from .utils import generate_dispatch_code, get_eat_time
from .draft_manager import get_draft_manager

# Set up logger
logger = logging.getLogger(__name__)

# Authentication views
def login_view(request):
    """Login view that authenticates against the API"""
    if request.method == 'POST':
        username = request.POST.get('username')
        password = request.POST.get('password')
        
        if not username or not password:
            messages.error(request, 'Please provide both username and password.')
            return render(request, 'dispatch/login.html')
            
        # Authenticate using our custom backend
        auth_backend = ApiAuthenticationBackend()
        user = auth_backend.authenticate(request, username=username, password=password)
        
        if user is not None:
            # Check if the user is a clerk and deny access
            if user.is_clerk():
                messages.error(request, 'Your user role does not have permission to access this application.')
                return render(request, 'dispatch/login.html')

            # Get the API token from the session (set during authentication)
            api_token = request.session.get('api_token')
            if not api_token:
                # If token is not in session, get it again
                try:
                    response = requests.post(
                        f"{settings.API_BASE_URL}/api/Auth/token",
                        json={
                            'username': username,
                            'password': password
                        },
                        headers={
                            'Content-Type': 'application/json',
                            'Accept': 'application/json'
                        },
                        timeout=10
                    )
                    
                    if response.status_code == 200:
                        token_data = response.json()
                        api_token = token_data.get('token')
                    else:
                        messages.error(request, 'Authentication failed: Could not get API token')
                        return render(request, 'dispatch/login.html')
                except Exception as e:
                    logger.error(f"Error getting API token: {str(e)}")
                    messages.error(request, 'Authentication failed: Could not connect to server')
                    return render(request, 'dispatch/login.html')
            
            # Log in the user using our custom login function
            login_user(request, user, api_token)
            messages.success(request, f'Welcome, {user.get_full_name() or user.username}!')
            
            # Redirect to the page they were trying to access, or dashboard
            next_url = request.GET.get('next', 'dashboard')
            return redirect(next_url)
        else:
            messages.error(request, 'Invalid username or password.')
            
    return render(request, 'dispatch/login.html')

def logout_view(request):
    """Logout view"""
    logout_user(request)
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
class ParcelViewSet(viewsets.ViewSet):
    api_client = WmsApiClient()
    
    def list(self, request):
        """Get all parcels from the API"""
        try:
            parcels = self.api_client.get_parcels(request)
            return Response(parcels)
        except Exception as e:
            logger.error(f"Error fetching parcels: {str(e)}")
            return Response({"error": str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)
    
    def retrieve(self, request, pk=None):
        """Get a specific parcel from the API"""
        try:
            parcel = self.api_client.get_parcel_by_id(pk, request)
            return Response(parcel)
        except Exception as e:
            logger.error(f"Error fetching parcel {pk}: {str(e)}")
            return Response({"error": str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)
    
    @action(detail=False, methods=['get'])
    def pending(self, request):
        """Get pending parcels from the API"""
        try:
            parcels = self.api_client.get_pending_parcels(request=request)
            return Response(parcels)
        except Exception as e:
            logger.error(f"Error fetching pending parcels: {str(e)}")
            return Response({"error": str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)

class DispatchViewSet(viewsets.ViewSet):
    api_client = WmsApiClient()

    def list(self, request):
        """Get all dispatches from the API"""
        try:
            dispatches = self.api_client.get_dispatches(request=request)
            return Response(dispatches)
        except Exception as e:
            logger.error(f"Error fetching dispatches: {str(e)}")
            return Response({"error": str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)
    
    def retrieve(self, request, pk=None):
        """Get a specific dispatch from the API"""
        try:
            dispatch = self.api_client.get_dispatch_by_id(pk, request)
            return Response(dispatch)
        except Exception as e:
            logger.error(f"Error fetching dispatch {pk}: {str(e)}")
            return Response({"error": str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)
    
    def create(self, request):
        """Create a new dispatch through the API"""
        try:
            dispatch = self.api_client.create_dispatch(request.data, request)
            return Response(dispatch, status=status.HTTP_201_CREATED)
        except Exception as e:
            logger.error(f"Error creating dispatch: {str(e)}")
            return Response({"error": str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)
    
    @action(detail=True, methods=['patch'])
    def update_status(self, request, pk=None):
        """Update a dispatch's status"""
        try:
            status = request.data.get('status')
            if status is None:
                return Response({"error": "Status is required"}, status=status.HTTP_400_BAD_REQUEST)
            
            dispatch = self.api_client.update_dispatch_status(pk, status, request)
            return Response(dispatch)
        except Exception as e:
            logger.error(f"Error updating dispatch {pk} status: {str(e)}")
            return Response({"error": str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)

    @action(detail=True, methods=['get'])
    def parcels(self, request, pk=None):
        """Get all parcels in a dispatch"""
        try:
            parcels = self.api_client.get_dispatch_parcels(pk, request)
            return Response(parcels)
        except Exception as e:
            logger.error(f"Error fetching parcels for dispatch {pk}: {str(e)}")
            return Response({"error": str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)

@method_decorator(login_required_api, name='dispatch')
class DashboardView(View):
    api_client = WmsApiClient()
    
    def get(self, request):
        """Dashboard view showing summary statistics"""
        branch_filter = None
        # Apply branch filter for managers, but not for admins
        if hasattr(request.user, 'is_manager') and request.user.is_manager() and not request.user.is_admin():
            branch_filter = request.user.branch.get('name')
            
        try:
            # Get today's date
            today = timezone.now().date()
            
            # Get counts and totals from API, filtered by branch if applicable
            parcel_count = self.api_client.get_parcel_count_for_date(today, request, branch=branch_filter)
            total_sales = self.api_client.get_total_sales_for_date(today, request, branch=branch_filter)
            pending_parcels = self.api_client.get_pending_parcels(request=request, branch=branch_filter)
        
            context = {
                'parcel_count': parcel_count,
                'total_sales': total_sales,
                'pending_count': len(pending_parcels),
                'today': today,
                'user': request.user,  # Explicitly pass user to template context
            }
        
        except Exception as e:
            logger.error(f"Error loading dashboard: {str(e)}")
            messages.error(request, "Error loading dashboard data")
            return render(request, 'dispatch/dashboard.html', {'user': request.user})
        return render(request, 'dispatch/dashboard.html', context)


@method_decorator(login_required_api, name='dispatch')
class ParcelListView(View):
    api_client = WmsApiClient()
    
    def get(self, request):
        """List all parcels from the API with filtering support"""
        context = {}
        branch_filter = None

        if hasattr(request.user, 'is_manager') and request.user.is_manager() and not request.user.is_admin():
            branch_filter = request.user.branch.get('name') if request.user.branch else None
        
        context['branch_filter_active'] = bool(branch_filter)
        context['user_branch'] = branch_filter

        try:
            # Preload data asynchronously
            self.api_client.preload_parcels_async(request, branch_filter)
            
            all_parcels = self.api_client.get_parcels(request, branch=branch_filter)
            users = self.api_client.get_users(request)
            user_map = {user['id']: user.get('username', 'N/A') for user in users}
            
            creators = {p.get('createdById'): user_map.get(p.get('createdById')) for p in all_parcels if p.get('createdById')}
            # Sort creators by username
            sorted_creators = sorted(creators.items(), key=lambda item: item[1])


            destinations = sorted(list(set(p['destination'] for p in all_parcels if p.get('destination'))))
            payment_methods = sorted(list(set(p['paymentMethods'] for p in all_parcels if p.get('paymentMethods'))))

            status_filter = request.GET.get('status')
            date_filter = request.GET.get('date')
            destination_filter = request.GET.get('destination')
            payment_mode_filter = request.GET.get('payment_mode')
            created_by_filter = request.GET.get('created_by')

            filtered_parcels = []
            for parcel in all_parcels:
                parcel['createdBy'] = user_map.get(parcel.get('createdById'))
                
                created_at_dt = None
                if parcel.get('createdAt'):
                    created_at_dt = parse_iso_datetime(parcel['createdAt'])
                
                matches = True
                if status_filter and str(parcel.get('status', '')) != status_filter:
                    matches = False
                if date_filter and (not created_at_dt or created_at_dt.date().isoformat() != date_filter):
                    matches = False
                if destination_filter and parcel.get('destination') != destination_filter:
                    matches = False
                if payment_mode_filter and parcel.get('paymentMethods') != payment_mode_filter:
                    matches = False
                if created_by_filter and str(parcel.get('createdById', '')) != created_by_filter:
                    matches = False
                
                if matches:
                    if created_at_dt:
                        parcel['createdAt'] = created_at_dt
                    filtered_parcels.append(parcel)

            context.update({
                'parcels': filtered_parcels,
                'status_choices': [(0, 'Pending'), (1, 'Finalized'), (2, 'In Transit'), (3, 'Delivered'), (4, 'Cancelled')],
                'destinations': destinations,
                'payment_methods': payment_methods,
                'creators': sorted_creators,
                'status_filter': status_filter,
                'date_filter': date_filter,
                'destination_filter': destination_filter,
                'payment_mode_filter': payment_mode_filter,
                'created_by_filter': created_by_filter,
                'user': request.user,  # Add user to template context
            })

        except Exception as e:
            messages.error(request, f"Error fetching parcel data: {str(e)}")
            context['parcels'] = []
            context['user'] = request.user  # Add user to error context

        return render(request, 'dispatch/parcel_list.html', context)


@method_decorator(login_required_api, name='dispatch')
class ParcelDetailView(View):
    api_client = WmsApiClient()

    def get(self, request, parcel_id):
        """Show details of a specific parcel"""
        try:
            parcel = self.api_client.get_parcel_by_id(parcel_id, request)
            if not parcel:
                messages.error(request, f"Parcel with ID {parcel_id} not found.")
                return redirect('parcel_list')

            users = self.api_client.get_users(request)
            user_map = {user['id']: user.get('username', 'N/A') for user in users}
            parcel['createdBy'] = user_map.get(parcel.get('createdById'))

            if parcel.get('createdAt'):
                parcel['createdAt'] = parse_iso_datetime(parcel['createdAt'])
            if parcel.get('dispatchedAt'):
                 parcel['dispatchedAt'] = parse_iso_datetime(parcel['dispatchedAt'])

            context = {
                'parcel': parcel, 
                'requested_parcel_id': parcel_id,
                'user': request.user,  # Add user to template context
            }
            return render(request, 'dispatch/parcel_detail.html', context)
            
        except Exception as e:
            messages.error(request, f"Error fetching parcel details: {str(e)}")
            return redirect('parcel_list')

@method_decorator(login_required_api, name='dispatch')
class DispatchListView(View):
    def get(self, request):
        """List all dispatches from the API with optimized loading"""
        api_client = WmsApiClient()
        branch_filter = None

        if hasattr(request.user, 'is_manager') and request.user.is_manager() and not request.user.is_admin():
            branch_filter = request.user.branch.get('name')

        try:
            # Use optimized summary endpoint first
            raw_dispatches_list = api_client.get_dispatches_summary(branch=branch_filter, request=request)
            
            if not raw_dispatches_list:
                return render(request, 'dispatch/dispatch_list.html', {'dispatches': [], 'user': request.user})
            
            dispatches = []
            for dispatch_summary in raw_dispatches_list:
                dispatch_id = dispatch_summary.get('id')
                if not dispatch_id:
                    continue
                
                # Check if summary includes calculated totals
                has_calculated_totals = 'totalParcels' in dispatch_summary or 'totalAmount' in dispatch_summary
                
                if not has_calculated_totals:
                    # If no pre-calculated totals, show estimated/placeholder values
                    total_parcels = dispatch_summary.get('parcelCount', 0)  # Fallback field name
                    total_amount = Decimal('0')  # Will show as estimate
                    needs_details = True
                else:
                    # Use pre-calculated values from API
                    total_parcels = dispatch_summary.get('totalParcels', 0)
                    total_amount = Decimal(str(dispatch_summary.get('totalAmount', 0) or 0))
                    needs_details = False
                
                # Use available summary data directly, avoid loading full details
                dispatches.append({
                    'id': dispatch_id,
                    'dispatch_code': dispatch_summary.get('dispatchCode', dispatch_id),
                    'destination': dispatch_summary.get('sourceBranch', 'N/A'),
                    'dispatch_date': parse_iso_datetime(dispatch_summary.get('dispatchTime')) if dispatch_summary.get('dispatchTime') else None,
                    'total_parcels': total_parcels,
                    'total_amount': total_amount,
                    'status': dispatch_summary.get('status', 'pending').lower(),
                    'vehicle_number': dispatch_summary.get('vehicleNumber', 'N/A'),
                    'driver': dispatch_summary.get('driver', 'N/A'),
                    'summary_only': True,  # Flag to indicate this is summary data
                    'needs_details': needs_details  # Flag for template to show "estimated" or "click for details"
                })

            logger.info(f"Successfully processed {len(dispatches)} dispatches using summary data")
            return render(request, 'dispatch/dispatch_list.html', {'dispatches': dispatches, 'user': request.user})
            
        except Exception as e:
            logger.error(f"Error loading dispatches: {str(e)}")
            messages.error(request, "Error loading dispatches")
            return render(request, 'dispatch/dispatch_list.html', {'dispatches': [], 'user': request.user})

@method_decorator(login_required_api, name='dispatch')
class DispatchDetailView(View):
    def get(self, request, dispatch_id):
        """Show details of a specific dispatch"""
        api_client = WmsApiClient()
        try:
            # Get dispatch data from API
            dispatch_data = api_client.get_dispatch_note(dispatch_id, request)
            
            if not dispatch_data:
                messages.error(request, "Dispatch not found")
                return redirect('dispatch_list')
            
            # Apply branch filtering for managers (security check)
            if hasattr(request.user, 'is_manager') and request.user.is_manager() and not request.user.is_admin():
                user_branch = request.user.branch.get('name') if request.user.branch else None
                dispatch_destination = dispatch_data.get('sourceBranch')
                
                if user_branch and dispatch_destination != user_branch:
                    messages.error(request, "Access denied. You can only view dispatches for your branch.")
                return redirect('dispatch_list')
            
            # Extract parcels from the response structure
            parcels_container = dispatch_data.get('parcels', {})
            parcels_list = parcels_container.get('$values', []) if isinstance(parcels_container, dict) else []
            
            # Parse dispatch date
            dispatch_date_str = dispatch_data.get('dispatchTime')
            dispatch_date = parse_iso_datetime(dispatch_date_str) if dispatch_date_str else None
            
            # Create dispatch context
            dispatch = {
                'id': dispatch_data.get('dispatchId'),
                'dispatch_code': dispatch_data.get('dispatchCode', dispatch_data.get('dispatchId')), # Fallback to ID
                'sourceBranch': dispatch_data.get('sourceBranch'),
                'destination': dispatch_data.get('sourceBranch'),  # Using sourceBranch as destination
                'vehicleNumber': dispatch_data.get('vehicleNumber'),
                'driver': dispatch_data.get('driver'),
                'dispatch_date': dispatch_date,  # Use parsed datetime object
                'status': dispatch_data.get('status', 'in_transit').lower(),
                'total_parcels': len(parcels_list),
                'vehicle_registration': dispatch_data.get('vehicleNumber'),
                'driver_name': dispatch_data.get('driver'),
            }
            
            # Calculate total amount from parcels
            total_amount = sum(
                p.get('amount', 0) 
                for p in parcels_list
                if isinstance(p.get('amount'), (int, float, Decimal))
            )
            dispatch['total_amount'] = total_amount
            
            # Format parcels data for template
            dispatch_parcels = []
            for parcel in parcels_list:
                formatted_parcel = {
                    'parcel': {
                        'id': parcel.get('id'),
                        'waybill_number': parcel.get('waybillNumber'),
                        'qr_code': parcel.get('qrCode'),
                        'sender': parcel.get('sender'),
                        'sender_telephone': parcel.get('senderTelephone'),
                        'receiver': parcel.get('receiver'),
                        'receiver_telephone': parcel.get('receiverTelephone'),
                        'description': parcel.get('description'),
                        'quantity': parcel.get('quantity', 1),
                        'amount': parcel.get('amount', 0),
                        'payment_methods': parcel.get('paymentMethods', 'N/A')
                    }
                }
                dispatch_parcels.append(formatted_parcel)
            
            context = {
                'dispatch': dispatch,
                'dispatch_parcels': dispatch_parcels,
                'user': request.user,  # Add user to template context
            }
            
            return render(request, 'dispatch/dispatch_detail.html', context)
        except Exception as e:
            logger.error(f"Error loading dispatch {dispatch_id}: {str(e)}", exc_info=True)
            messages.error(request, "Error loading dispatch details")
            return redirect('dispatch_list')

@method_decorator(login_required_api, name='dispatch')
class CreateDispatchView(View):
    def get(self, request):
        """Show form to create a new dispatch, handling shared dispatch drafts."""
        api_client = WmsApiClient()
        context = {}

        # Use shared draft manager instead of session
        draft_manager = get_draft_manager(request.user)
        dispatch_drafts = draft_manager.get_all_drafts()
        
        # Get all parcel IDs that are in any draft
        all_draft_parcel_ids = set()
        for destination, draft_data in dispatch_drafts.items():
            all_draft_parcel_ids.update(draft_data.get('parcel_ids', []))
        
        context['dispatch_drafts'] = dispatch_drafts
        context['draft_count'] = len(dispatch_drafts)
        
        branch_filter = None
        if hasattr(request.user, 'is_manager') and request.user.is_manager() and not request.user.is_admin():
            branch_filter = request.user.branch.get('name')

        try:
            # Use concurrent fetching for better performance
            import concurrent.futures
            
            def fetch_pending_parcels():
                return api_client.get_pending_parcels(request=request, branch=branch_filter)
            
            def fetch_users():
                return api_client.get_users(request)
            
            # Fetch data concurrently
            with concurrent.futures.ThreadPoolExecutor(max_workers=2) as executor:
                pending_parcels_future = executor.submit(fetch_pending_parcels)
                users_future = executor.submit(fetch_users)
                
                # Get results
                pending_parcels_all = pending_parcels_future.result()
                users = users_future.result()
            
            user_map = {user['id']: user.get('username', 'N/A') for user in users}
            
            # Populate filter dropdowns
            context['available_destinations'] = sorted(list(set(p['destination'] for p in pending_parcels_all if p.get('destination'))))
            context['available_payment_methods'] = sorted(list(set(p['paymentMethods'] for p in pending_parcels_all if p.get('paymentMethods'))))
            creators = {p.get('createdById'): user_map.get(p.get('createdById')) for p in pending_parcels_all if p.get('createdById')}
            context['available_creators'] = sorted(creators.items(), key=lambda item: item[1])

            # Get and apply filters
            date_filter = request.GET.get('date_filter')
            payment_mode_filter = request.GET.get('payment_mode_filter')
            created_by_filter = request.GET.get('created_by_filter')
            destination_filter = request.GET.get('destination_filter')
            
            # Get parcel draft information
            parcel_ids = [p['id'] for p in pending_parcels_all]
            parcel_draft_info = draft_manager.get_parcel_draft_info(parcel_ids)
            
            filtered_parcels = []
            for p in pending_parcels_all:
                p['createdBy'] = user_map.get(p.get('createdById'))
                
                # Add draft information
                parcel_info = parcel_draft_info.get(p['id'], {})
                p['is_in_draft'] = parcel_info.get('is_in_draft', False)
                p['draft_destination'] = parcel_info.get('draft_destination')
                p['draft_contributors'] = parcel_info.get('draft_contributors', [])
                
                created_at_dt = parse_iso_datetime(p['createdAt']) if p.get('createdAt') else None
                
                matches = True
                if date_filter and (not created_at_dt or created_at_dt.date().isoformat() != date_filter):
                    matches = False
                if payment_mode_filter and p.get('paymentMethods') != payment_mode_filter:
                    matches = False
                if created_by_filter and str(p.get('createdById', '')) != created_by_filter:
                    matches = False
                if destination_filter and p.get('destination') != destination_filter:
                    matches = False
                
                if matches:
                    filtered_parcels.append(p)
            
            context.update({
                'parcels': filtered_parcels,
                'date_filter_value': date_filter,
                'payment_mode_filter_value': payment_mode_filter,
                'created_by_filter_value': created_by_filter,
                'destination_filter_value': destination_filter,
                'user': request.user,  # Add user to template context
            })
            return render(request, 'dispatch/create_dispatch.html', context)
        except Exception as e:
            logger.error(f"Error loading pending parcels: {str(e)}")
            messages.error(request, "Error loading pending parcels")
            return render(request, 'dispatch/create_dispatch.html', {'parcels': [], 'user': request.user})
    
    def post(self, request):
        """Create a new dispatch or manage shared dispatch drafts."""
        api_client = WmsApiClient()
        draft_manager = get_draft_manager(request.user)
        action = request.POST.get('action')
        
        # Define branch filter for managers
        branch_filter = None
        if hasattr(request.user, 'is_manager') and request.user.is_manager() and not request.user.is_admin():
            branch_filter = request.user.branch.get('name')

        # Handle draft management actions
        if action == 'save_draft':
            destination = request.POST.get('destination')
            if not destination:
                messages.error(request, "Destination is required to save a draft.")
                return redirect('create_dispatch')

            existing_draft = draft_manager.get_draft(destination)
            existing_parcel_ids = existing_draft.get('parcel_ids', []) if existing_draft else []
            
            newly_selected_ids = request.POST.getlist('parcel_ids')
            all_parcel_ids = list(set(existing_parcel_ids + newly_selected_ids))
            
            success, message = draft_manager.save_draft(
                destination=destination,
                parcel_ids=all_parcel_ids,
                vehicle_registration=request.POST.get('vehicle_registration'),
                driver_name=request.POST.get('driver_name'),
                user=request.user
            )
            
            if success:
                messages.success(request, message)
            else:
                messages.error(request, message)
                return redirect('create_dispatch')

        elif action == 'clear_draft':
            destination = request.POST.get('destination')
            if destination:
                success, message = draft_manager.clear_draft(destination, request.user)
                if success:
                    messages.info(request, message)
                else:
                    messages.error(request, message)
            else:
                # Clear all drafts if no destination is specified
                success, message = draft_manager.clear_all_drafts(request.user)
                if success:
                    messages.info(request, message)
                else:
                    messages.error(request, message)
            return redirect('create_dispatch')
        
        # Handle dispatch creation actions
        elif action == 'finalize_dispatch':
            destination = request.POST.get('destination')
            if not destination:
                messages.error(request, "Destination is required to finalize a dispatch.")
                return redirect('create_dispatch')

            draft_data = draft_manager.get_draft(destination)
            if not draft_data:
                messages.error(request, "No draft found for this destination.")
                return redirect('create_dispatch')
                
            parcel_ids = draft_data.get('parcel_ids', [])

            if not parcel_ids:
                messages.error(request, "Cannot finalize an empty dispatch. The draft is empty.")
                return redirect('create_dispatch')
            
            dispatch_data = {
                'parcel_ids': parcel_ids,
                'destination': destination,
                'vehicle_registration': draft_data.get('vehicle_registration'),
                'driver_name': draft_data.get('driver_name'),
                'dispatchCode': generate_dispatch_code(destination),
                'sourceBranch': destination,  # Use destination as sourceBranch
                'dispatchTime': get_eat_time().isoformat(),
            }
            
            # Log the generated dispatch code for debugging
            logger.info(f"Generated dispatch code: {dispatch_data['dispatchCode']}")
            logger.info(f"Dispatch data being sent: {dispatch_data}")

        elif action == 'create_dispatch':
            destination = request.POST.get('destination')
            if not destination:
                messages.error(request, 'You must select a destination.')
                return redirect('create_dispatch')

            parcel_ids = request.POST.getlist('parcel_ids')
            if not parcel_ids:
                messages.error(request, 'You must select at least one parcel to create a dispatch.')
                return redirect('create_dispatch')

            dispatch_data = {
                'parcel_ids': parcel_ids,
                'destination': destination,
                'vehicle_registration': request.POST.get('vehicle_registration'),
                'driver_name': request.POST.get('driver_name'),
                'dispatchCode': generate_dispatch_code(destination),
                'sourceBranch': destination,  # Use destination as sourceBranch
                'dispatchTime': get_eat_time().isoformat(),
            }
            
            # Log the generated dispatch code for debugging
            logger.info(f"Generated dispatch code: {dispatch_data['dispatchCode']}")
            logger.info(f"Dispatch data being sent: {dispatch_data}")
        else:
            messages.error(request, f"Unknown action requested: {action}")
            return redirect('create_dispatch')
        
        # Create the dispatch
        try:
            dispatch = api_client.create_dispatch(dispatch_data, request)

            if dispatch and dispatch.get('id'):
                # Clear caches since data has changed
                api_client.clear_parcels_cache(branch_filter)
                api_client.clear_pending_parcels_cache(branch_filter)
                api_client.clear_dispatch_cache(branch=branch_filter)  # Clear dispatch caches
                # Update parcel statuses from "pending" to "in_transit"
                try:
                    parcel_ids = dispatch_data.get('parcel_ids', [])
                    if parcel_ids:
                        # Update parcel statuses to "in_transit" (status code 2)
                        status_update_result = api_client.update_parcels_status_batch(parcel_ids, 2, request)
                        if status_update_result:
                            logger.info(f"Successfully updated {len(parcel_ids)} parcels to in_transit status")
                        else:
                            logger.warning(f"Failed to update parcel statuses for dispatch {dispatch.get('id')}")
                except Exception as status_error:
                    logger.error(f"Error updating parcel statuses: {status_error}")
                    # Don't fail the dispatch creation if status update fails
                    messages.warning(request, "Dispatch created successfully, but there was an issue updating parcel statuses.")
                
                # Clear the shared draft after successful dispatch creation
                destination = dispatch_data.get('destination')
                if destination:
                    success, message = draft_manager.clear_draft(destination, request.user)
                    if not success:
                        logger.warning(f"Failed to clear draft after dispatch creation: {message}")
                
                messages.success(request, f"Dispatch {dispatch.get('dispatchCode', '')} created successfully!")
                return redirect('dispatch_detail', dispatch_id=dispatch.get('id'))
            else:
                messages.error(request, "Failed to create dispatch. The API rejected the request or returned an invalid object. Please check the server logs for more details.")
                return redirect('create_dispatch')

        except Exception as e:
            logger.error(f"Error creating dispatch: {e}", exc_info=True)
            messages.error(request, f"An unexpected error occurred while creating the dispatch: {e}")
            return redirect('create_dispatch')

@method_decorator(login_required_api, name='dispatch')
class ConsignmentNoteView(View):
    api_client = WmsApiClient()
        
    def get(self, request, parcel_id):
        """Show printable consignment note for a specific parcel"""
        try:
            parcel = self.api_client.get_parcel_by_id(parcel_id, request)
            if not parcel:
                messages.error(request, f"Parcel with ID {parcel_id} not found.")
                return redirect('parcel_list')

            users = self.api_client.get_users(request)
            user_map = {user['id']: user.get('username', 'N/A') for user in users}
            parcel['createdBy'] = user_map.get(parcel.get('createdById'))

            if parcel.get('createdAt'):
                parcel['createdAt'] = parse_iso_datetime(parcel['createdAt'])
            if parcel.get('dispatchedAt'):
                parcel['dispatchedAt'] = parse_iso_datetime(parcel['dispatchedAt'])

            return render(request, 'dispatch/consignment_note.html', {'parcel': parcel, 'user': request.user})

        except Exception as e:
            messages.error(request, f"Error generating consignment note: {str(e)}")
            return redirect('parcel_list')


@method_decorator(login_required_api, name='dispatch')
class DispatchNoteView(View):
    api_client = WmsApiClient()
        
    def get(self, request, dispatch_id):
        """Show dispatch note with all parcels"""
        try:
            dispatch_data = self.api_client.get_dispatch_note(dispatch_id, request)
            if not dispatch_data:
                messages.error(request, "Dispatch data not found.")
                return redirect('dispatch_list')
            
            # Apply branch filtering for managers (security check)
            if hasattr(request.user, 'is_manager') and request.user.is_manager() and not request.user.is_admin():
                user_branch = request.user.branch.get('name') if request.user.branch else None
                dispatch_destination = dispatch_data.get('sourceBranch')
                
                if user_branch and dispatch_destination != user_branch:
                    messages.error(request, "Access denied. You can only view dispatch notes for your branch.")
                    return redirect('dispatch_list')

            parcels = dispatch_data.get('parcels', {}).get('$values', [])
            
            users = self.api_client.get_users(request)
            user_map = {user['id']: user.get('username', 'N/A') for user in users}

            total_cod = Decimal(0)
            total_paid = Decimal(0)
            total_contract = Decimal(0)
            
            # Use a list for parcels to be passed to the template
            template_parcels = []
            for p_data in parcels:
                p_data['createdBy'] = user_map.get(p_data.get('createdById'))
                
                amount = Decimal(p_data.get('amount', 0) or 0)
                payment_method = p_data.get('paymentMethods', '').lower()

                if payment_method == 'cod':
                    total_cod += amount
                elif payment_method == 'paid':
                    total_paid += amount
                elif payment_method == 'contract':
                    total_contract += amount
                
                template_parcels.append({'parcel': p_data})

            # Re-structure dispatch data for template compatibility
            dispatch_context = {
                'id': dispatch_data.get('dispatchId'),
                'dispatch_code': dispatch_data.get('dispatchCode', dispatch_data.get('dispatchId')), # Fallback to ID
                'destination': dispatch_data.get('sourceBranch'),
                'dispatch_date': parse_iso_datetime(dispatch_data.get('dispatchTime')) if dispatch_data.get('dispatchTime') else None,
                'total_parcels': len(parcels),
                'total_amount': sum(Decimal(p['parcel'].get('amount', 0) or 0) for p in template_parcels),
                'vehicle_registration': dispatch_data.get('vehicleNumber'),
                'driver_name': dispatch_data.get('driver'),
                'status': dispatch_data.get('status', 'in_transit').lower(),
            }
            
            context = {
                'dispatch': dispatch_context,
                'dispatch_parcels': template_parcels,
                'total_cod_amount': total_cod,
                'total_paid_amount': total_paid,
                'total_contract_amount': total_contract,
                'calculated_overall_total': total_cod + total_paid + total_contract,
                'user': request.user,  # Add user to template context
            }
            return render(request, 'dispatch/dispatch_note.html', context)
            
        except Exception as e:
            messages.error(request, f"Error fetching dispatch note: {str(e)}")
            return redirect('dispatch_list')

@method_decorator(login_required_api, name='dispatch')
class ReportsView(View):
    """Main reports dashboard showing all available report types"""
    
    def get(self, request):
        # Check if user is admin
        if not hasattr(request.user, 'is_admin_property') or not request.user.is_admin_property:
            messages.error(request, 'Access denied. Reports are only available to administrators.')
            return redirect('dashboard')
            
        context = {
            'page_title': 'Reports Dashboard',
            'user': request.user,  # Add user to template context
        }
        return render(request, 'dispatch/reports/reports_dashboard.html', context)

@method_decorator(login_required_api, name='dispatch')
class SalesPerClerkReportView(View):
    """Report showing sales performance per clerk/processor"""
    api_client = WmsApiClient()
    
    def get(self, request):
        # Check if user is admin
        if not hasattr(request.user, 'is_admin_property') or not request.user.is_admin_property:
            messages.error(request, 'Access denied. Reports are only available to administrators.')
            return redirect('dashboard')
            
        context = {}
        branch_filter = None
        
        # Apply branch filter for managers
        if hasattr(request.user, 'is_manager') and request.user.is_manager() and not request.user.is_admin():
            branch_filter = request.user.branch.get('name')
        
        # Get filter parameters
        start_date = request.GET.get('start_date')
        end_date = request.GET.get('end_date')
        branch_filter_param = request.GET.get('branch_filter') or branch_filter
        
        try:
            # Get all parcels
            all_parcels = self.api_client.get_parcels(request, branch=branch_filter_param)
            users = self.api_client.get_users(request)
            user_map = {user['id']: user for user in users}
            
            # Filter by date range if provided
            filtered_parcels = []
            for parcel in all_parcels:
                if parcel.get('createdAt'):
                    parcel_date = parse_iso_datetime(parcel['createdAt'])
                    if parcel_date:
                        parcel_date_only = parcel_date.date()
                        
                        # Apply date filters
                        if start_date and parcel_date_only < datetime.strptime(start_date, '%Y-%m-%d').date():
                            continue
                        if end_date and parcel_date_only > datetime.strptime(end_date, '%Y-%m-%d').date():
                            continue
                        
                        filtered_parcels.append(parcel)
            
            # Calculate sales per clerk
            sales_by_clerk = {}
            for parcel in filtered_parcels:
                clerk_id = parcel.get('createdById')
                clerk_data = user_map.get(clerk_id, {})
                clerk_name = clerk_data.get('username', f'Unknown User {clerk_id}')
                clerk_full_name = f"{clerk_data.get('firstName', '')} {clerk_data.get('lastName', '')}".strip()
                if not clerk_full_name:
                    clerk_full_name = clerk_name
                
                amount = Decimal(parcel.get('totalAmount', 0) or 0)
                
                if clerk_id not in sales_by_clerk:
                    sales_by_clerk[clerk_id] = {
                        'clerk_name': clerk_full_name,
                        'clerk_username': clerk_name,
                        'total_sales': Decimal('0'),
                        'total_parcels': 0,
                        'parcels': []
                    }
                
                sales_by_clerk[clerk_id]['total_sales'] += amount
                sales_by_clerk[clerk_id]['total_parcels'] += 1
                sales_by_clerk[clerk_id]['parcels'].append(parcel)
            
            # Calculate average per parcel for each clerk
            for clerk_data in sales_by_clerk.values():
                if clerk_data['total_parcels'] > 0:
                    clerk_data['average_per_parcel'] = clerk_data['total_sales'] / clerk_data['total_parcels']
                else:
                    clerk_data['average_per_parcel'] = Decimal('0')
            
            # Sort by total sales descending
            sorted_sales = sorted(sales_by_clerk.values(), key=lambda x: x['total_sales'], reverse=True)
            
            # Get available branches for filter
            available_branches = sorted(list(set(p.get('destination', '') for p in all_parcels if p.get('destination'))))
            
            context.update({
                'sales_data': sorted_sales,
                'start_date': start_date,
                'end_date': end_date,
                'branch_filter': branch_filter_param,
                'available_branches': available_branches,
                'total_sales': sum(clerk['total_sales'] for clerk in sorted_sales),
                'total_parcels': sum(clerk['total_parcels'] for clerk in sorted_sales),
                'page_title': 'Sales Performance Report by Clerk',
                'user': request.user,  # Add user to template context
            })
            
        except Exception as e:
            logger.error(f"Error generating sales per clerk report: {str(e)}")
            messages.error(request, f"Error generating report: {str(e)}")
            context['sales_data'] = []
            context['user'] = request.user  # Add user to error context
        
        return render(request, 'dispatch/reports/sales_per_clerk.html', context)

@method_decorator(login_required_api, name='dispatch')
class ContractInvoicesReportView(View):
    """Report for generating invoices for parcels with 'Contract' payment method"""
    api_client = WmsApiClient()
    
    def get(self, request):
        # Check if user is admin
        if not hasattr(request.user, 'is_admin_property') or not request.user.is_admin_property:
            messages.error(request, 'Access denied. Reports are only available to administrators.')
            return redirect('dashboard')
            
        context = {}
        branch_filter = None
        
        # Apply branch filter for managers
        if hasattr(request.user, 'is_manager') and request.user.is_manager() and not request.user.is_admin():
            branch_filter = request.user.branch.get('name')
        
        # Get filter parameters
        start_date = request.GET.get('start_date')
        end_date = request.GET.get('end_date')
        branch_filter_param = request.GET.get('branch_filter') or branch_filter
        destination_filter = request.GET.get('destination_filter')
        
        try:
            # Get all parcels
            all_parcels = self.api_client.get_parcels(request, branch=branch_filter_param)
            
            # Filter for contract payment parcels
            contract_parcels = []
            for parcel in all_parcels:
                if parcel.get('paymentMethods', '').lower() == 'contract':
                    if parcel.get('createdAt'):
                        parcel_date = parse_iso_datetime(parcel['createdAt'])
                        if parcel_date:
                            parcel_date_only = parcel_date.date()
                            
                            # Apply date filters
                            if start_date and parcel_date_only < datetime.strptime(start_date, '%Y-%m-%d').date():
                                continue
                            if end_date and parcel_date_only > datetime.strptime(end_date, '%Y-%m-%d').date():
                                continue
                            
                            # Apply destination filter
                            if destination_filter and parcel.get('destination') != destination_filter:
                                continue
                            
                            parcel['parsedCreatedAt'] = parcel_date
                            contract_parcels.append(parcel)
            
            # Group by destination for invoice generation
            invoices_by_destination = {}
            for parcel in contract_parcels:
                destination = parcel.get('destination', 'Unknown')
                if destination not in invoices_by_destination:
                    invoices_by_destination[destination] = {
                        'destination': destination,
                        'parcels': [],
                        'total_amount': Decimal('0'),
                        'total_parcels': 0
                    }
                
                amount = Decimal(parcel.get('totalAmount', 0) or 0)
                invoices_by_destination[destination]['parcels'].append(parcel)
                invoices_by_destination[destination]['total_amount'] += amount
                invoices_by_destination[destination]['total_parcels'] += 1
            
            # Get available destinations for filter
            available_destinations = sorted(list(set(p.get('destination', '') for p in all_parcels if p.get('destination'))))
            
            context.update({
                'invoices_data': list(invoices_by_destination.values()),
                'contract_parcels': contract_parcels,
                'start_date': start_date,
                'end_date': end_date,
                'branch_filter': branch_filter_param,
                'destination_filter': destination_filter,
                'available_destinations': available_destinations,
                'total_amount': sum(inv['total_amount'] for inv in invoices_by_destination.values()),
                'total_parcels': len(contract_parcels),
                'page_title': 'Contract Payment Invoices Report',
                'user': request.user,  # Add user to template context
            })
            
        except Exception as e:
            logger.error(f"Error generating contract invoices report: {str(e)}")
            messages.error(request, f"Error generating report: {str(e)}")
            context['invoices_data'] = []
            context['user'] = request.user  # Add user to error context
        
        return render(request, 'dispatch/reports/contract_invoices.html', context)

@method_decorator(login_required_api, name='dispatch')
class UndeliveredParcelsReportView(View):
    """Report showing undelivered parcels in dispatches"""
    api_client = WmsApiClient()
    
    def get(self, request):
        # Check if user is admin
        if not hasattr(request.user, 'is_admin_property') or not request.user.is_admin_property:
            messages.error(request, 'Access denied. Reports are only available to administrators.')
            return redirect('dashboard')
            
        context = {}
        branch_filter = None
        
        # Apply branch filter for managers
        if hasattr(request.user, 'is_manager') and request.user.is_manager() and not request.user.is_admin():
            branch_filter = request.user.branch.get('name')
        
        # Get filter parameters
        dispatch_filter = request.GET.get('dispatch_filter')
        destination_filter = request.GET.get('destination_filter')
        branch_filter_param = request.GET.get('branch_filter') or branch_filter
        
        try:
            # Get all dispatches
            all_dispatches = self.api_client.get_dispatches(request=request, branch=branch_filter_param)
            
            undelivered_data = []
            available_dispatches = []
            available_destinations = set()
            
            for dispatch_summary in all_dispatches:
                dispatch_id = dispatch_summary.get('id')
                if not dispatch_id:
                    continue
                
                # Get dispatch details with parcels
                try:
                    dispatch_details = self.api_client.get_dispatch_note(dispatch_id, request)
                    if not dispatch_details:
                        continue
                    
                    dispatch_code = dispatch_details.get('dispatchCode', dispatch_id)
                    destination = dispatch_details.get('sourceBranch', 'Unknown')
                    available_destinations.add(destination)
                    
                    available_dispatches.append({
                        'id': dispatch_id,
                        'code': dispatch_code,
                        'destination': destination
                    })
                    
                    # Apply filters
                    if dispatch_filter and dispatch_id != dispatch_filter:
                        continue
                    if destination_filter and destination != destination_filter:
                        continue
                    
                    parcels_list = dispatch_details.get('parcels', {}).get('$values', [])
                    
                    # Filter for undelivered parcels (status != 3 - delivered)
                    undelivered_parcels = []
                    for parcel in parcels_list:
                        parcel_status = parcel.get('status', 0)
                        if parcel_status != 3:  # Not delivered
                            # Calculate days since dispatch
                            days_since_dispatch = 0
                            if dispatch_date:
                                from django.utils import timezone
                                days_diff = (timezone.now() - dispatch_date).days
                                days_since_dispatch = max(0, days_diff)
                            
                            parcel['days_since_dispatch'] = days_since_dispatch
                            undelivered_parcels.append(parcel)
                    
                    if undelivered_parcels:
                        dispatch_date = None
                        if dispatch_details.get('dispatchTime'):
                            dispatch_date = parse_iso_datetime(dispatch_details.get('dispatchTime'))
                        
                        total_amount = sum(Decimal(p.get('amount', 0) or 0) for p in undelivered_parcels)
                        
                        undelivered_data.append({
                            'dispatch_id': dispatch_id,
                            'dispatch_code': dispatch_code,
                            'destination': destination,
                            'dispatch_date': dispatch_date,
                            'vehicle_number': dispatch_details.get('vehicleNumber', 'N/A'),
                            'driver': dispatch_details.get('driver', 'N/A'),
                            'undelivered_parcels': undelivered_parcels,
                            'total_undelivered': len(undelivered_parcels),
                            'total_amount': total_amount
                        })
                        
                except Exception as e:
                    logger.warning(f"Error processing dispatch {dispatch_id}: {str(e)}")
                    continue
            
            context.update({
                'undelivered_data': undelivered_data,
                'available_dispatches': available_dispatches,
                'available_destinations': sorted(list(available_destinations)),
                'dispatch_filter': dispatch_filter,
                'destination_filter': destination_filter,
                'branch_filter': branch_filter_param,
                'total_undelivered': sum(data['total_undelivered'] for data in undelivered_data),
                'total_amount': sum(data['total_amount'] for data in undelivered_data),
                'page_title': 'Undelivered Parcels Report',
                'user': request.user,  # Add user to template context
            })
            
        except Exception as e:
            logger.error(f"Error generating undelivered parcels report: {str(e)}")
            messages.error(request, f"Error generating report: {str(e)}")
            context['undelivered_data'] = []
            context['user'] = request.user  # Add user to error context
        
        return render(request, 'dispatch/reports/undelivered_parcels.html', context)

@method_decorator(login_required_api, name='dispatch')
class CODDeliveredReportView(View):
    """Report showing delivered COD parcels and amounts"""
    api_client = WmsApiClient()
    
    def get(self, request):
        # Check if user is admin
        if not hasattr(request.user, 'is_admin_property') or not request.user.is_admin_property:
            messages.error(request, 'Access denied. Reports are only available to administrators.')
            return redirect('dashboard')
            
        context = {}
        branch_filter = None
        
        # Apply branch filter for managers
        if hasattr(request.user, 'is_manager') and request.user.is_manager() and not request.user.is_admin():
            branch_filter = request.user.branch.get('name')
        
        # Get filter parameters
        start_date = request.GET.get('start_date')
        end_date = request.GET.get('end_date')
        dispatch_filter = request.GET.get('dispatch_filter')
        destination_filter = request.GET.get('destination_filter')
        branch_filter_param = request.GET.get('branch_filter') or branch_filter
        
        try:
            # Get all dispatches
            all_dispatches = self.api_client.get_dispatches(request=request, branch=branch_filter_param)
            
            cod_delivered_data = []
            available_dispatches = []
            available_destinations = set()
            
            for dispatch_summary in all_dispatches:
                dispatch_id = dispatch_summary.get('id')
                if not dispatch_id:
                    continue
                
                try:
                    dispatch_details = self.api_client.get_dispatch_note(dispatch_id, request)
                    if not dispatch_details:
                        continue
                    
                    dispatch_code = dispatch_details.get('dispatchCode', dispatch_id)
                    destination = dispatch_details.get('sourceBranch', 'Unknown')
                    available_destinations.add(destination)
                    
                    dispatch_date = None
                    if dispatch_details.get('dispatchTime'):
                        dispatch_date = parse_iso_datetime(dispatch_details.get('dispatchTime'))
                    
                    available_dispatches.append({
                        'id': dispatch_id,
                        'code': dispatch_code,
                        'destination': destination,
                        'date': dispatch_date
                    })
                    
                    # Apply date filters
                    if start_date and dispatch_date:
                        if dispatch_date.date() < datetime.strptime(start_date, '%Y-%m-%d').date():
                            continue
                    if end_date and dispatch_date:
                        if dispatch_date.date() > datetime.strptime(end_date, '%Y-%m-%d').date():
                            continue
                    
                    # Apply other filters
                    if dispatch_filter and dispatch_id != dispatch_filter:
                        continue
                    if destination_filter and destination != destination_filter:
                        continue
                    
                    parcels_list = dispatch_details.get('parcels', {}).get('$values', [])
                    
                    # Filter for delivered COD parcels
                    cod_delivered_parcels = []
                    for parcel in parcels_list:
                        payment_method = parcel.get('paymentMethods', '').lower()
                        parcel_status = parcel.get('status', 0)
                        
                        if payment_method == 'cod' and parcel_status == 3:  # Delivered
                            cod_delivered_parcels.append(parcel)
                    
                    if cod_delivered_parcels:
                        total_cod_amount = sum(Decimal(p.get('amount', 0) or 0) for p in cod_delivered_parcels)
                        total_cod_parcels = len(cod_delivered_parcels)
                        
                        # Calculate average per parcel
                        average_per_parcel = total_cod_amount / total_cod_parcels if total_cod_parcels > 0 else Decimal('0')
                        
                        cod_delivered_data.append({
                            'dispatch_id': dispatch_id,
                            'dispatch_code': dispatch_code,
                            'destination': destination,
                            'dispatch_date': dispatch_date,
                            'vehicle_number': dispatch_details.get('vehicleNumber', 'N/A'),
                            'driver': dispatch_details.get('driver', 'N/A'),
                            'cod_parcels': cod_delivered_parcels,
                            'total_cod_parcels': total_cod_parcels,
                'total_cod_amount': total_cod_amount,
                            'average_per_parcel': average_per_parcel
                        })
                        
                except Exception as e:
                    logger.warning(f"Error processing dispatch {dispatch_id}: {str(e)}")
                    continue
            
            context.update({
                'cod_delivered_data': cod_delivered_data,
                'available_dispatches': available_dispatches,
                'available_destinations': sorted(list(available_destinations)),
                'start_date': start_date,
                'end_date': end_date,
                'dispatch_filter': dispatch_filter,
                'destination_filter': destination_filter,
                'branch_filter': branch_filter_param,
                'total_cod_parcels': sum(data['total_cod_parcels'] for data in cod_delivered_data),
                'total_cod_amount': sum(data['total_cod_amount'] for data in cod_delivered_data),
                'overall_average_per_parcel': (
                    sum(data['total_cod_amount'] for data in cod_delivered_data) / 
                    sum(data['total_cod_parcels'] for data in cod_delivered_data) 
                    if sum(data['total_cod_parcels'] for data in cod_delivered_data) > 0 
                    else Decimal('0')
                ),
                'page_title': 'Delivered COD Parcels Report',
                'user': request.user,  # Add user to template context
            })
            
        except Exception as e:
            logger.error(f"Error generating COD delivered report: {str(e)}")
            messages.error(request, f"Error generating report: {str(e)}")
            context['cod_delivered_data'] = []
            context['user'] = request.user  # Add user to error context
        
        return render(request, 'dispatch/reports/cod_delivered.html', context)

@method_decorator(login_required_api, name='dispatch')
class DeliveryRateReportView(View):
    """Report showing parcel delivery rate per branch"""
    api_client = WmsApiClient()
    
    def get(self, request):
        # Check if user is admin
        if not hasattr(request.user, 'is_admin_property') or not request.user.is_admin_property:
            messages.error(request, 'Access denied. Reports are only available to administrators.')
            return redirect('dashboard')
            
        context = {}
        branch_filter = None
        
        # Apply branch filter for managers
        if hasattr(request.user, 'is_manager') and request.user.is_manager() and not request.user.is_admin():
            branch_filter = request.user.branch.get('name')
        
        # Get filter parameters
        start_date = request.GET.get('start_date')
        end_date = request.GET.get('end_date')
        branch_filter_param = request.GET.get('branch_filter') or branch_filter
        
        try:
            # Get all parcels
            all_parcels = self.api_client.get_parcels(request, branch=branch_filter_param)
            
            # Filter by date range if provided
            filtered_parcels = []
            for parcel in all_parcels:
                if parcel.get('createdAt'):
                    parcel_date = parse_iso_datetime(parcel['createdAt'])
                    if parcel_date:
                        parcel_date_only = parcel_date.date()
                        
                        # Apply date filters
                        if start_date and parcel_date_only < datetime.strptime(start_date, '%Y-%m-%d').date():
                            continue
                        if end_date and parcel_date_only > datetime.strptime(end_date, '%Y-%m-%d').date():
                            continue
                        
                        filtered_parcels.append(parcel)
            
            # Calculate delivery rates per destination (branch)
            delivery_stats = {}
            for parcel in filtered_parcels:
                destination = parcel.get('destination', 'Unknown')
                status = parcel.get('status', 0)
                
                if destination not in delivery_stats:
                    delivery_stats[destination] = {
                        'destination': destination,
                        'total_parcels': 0,
                        'delivered_parcels': 0,
                        'pending_parcels': 0,
                        'in_transit_parcels': 0,
                        'cancelled_parcels': 0,
                        'delivery_rate': 0.0
                    }
                
                delivery_stats[destination]['total_parcels'] += 1
                
                if status == 3:  # Delivered
                    delivery_stats[destination]['delivered_parcels'] += 1
                elif status == 0:  # Pending
                    delivery_stats[destination]['pending_parcels'] += 1
                elif status == 2:  # In Transit
                    delivery_stats[destination]['in_transit_parcels'] += 1
                elif status == 4:  # Cancelled
                    delivery_stats[destination]['cancelled_parcels'] += 1
            
            # Calculate delivery rates
            for destination_stats in delivery_stats.values():
                total = destination_stats['total_parcels']
                delivered = destination_stats['delivered_parcels']
                if total > 0:
                    destination_stats['delivery_rate'] = (delivered / total) * 100
                else:
                    destination_stats['delivery_rate'] = 0.0
            
            # Sort by delivery rate descending
            sorted_delivery_stats = sorted(delivery_stats.values(), key=lambda x: x['delivery_rate'], reverse=True)
            
            # Calculate overall statistics
            total_parcels = sum(stats['total_parcels'] for stats in delivery_stats.values())
            total_delivered = sum(stats['delivered_parcels'] for stats in delivery_stats.values())
            overall_delivery_rate = (total_delivered / total_parcels * 100) if total_parcels > 0 else 0
            
            # Get available destinations for filter
            available_destinations = sorted(list(set(p.get('destination', '') for p in all_parcels if p.get('destination'))))
            
            context.update({
                'delivery_stats': sorted_delivery_stats,
                'start_date': start_date,
                'end_date': end_date,
                'branch_filter': branch_filter_param,
                'available_destinations': available_destinations,
                'total_parcels': total_parcels,
                'total_delivered': total_delivered,
                'overall_delivery_rate': overall_delivery_rate,
                'page_title': 'Delivery Rate Report by Branch',
                'user': request.user,  # Add user to template context
            })
            
        except Exception as e:
            logger.error(f"Error generating delivery rate report: {str(e)}")
            messages.error(request, f"Error generating report: {str(e)}")
            context['delivery_stats'] = []
            context['user'] = request.user  # Add user to error context
        
        return render(request, 'dispatch/reports/delivery_rate.html', context)

@method_decorator(login_required_api, name='dispatch')
class DebugAuthView(View):
    """Debug view to check user authentication and role information"""
    
    def get(self, request):
        context = {
            'user': request.user,
            'is_authenticated': request.user.is_authenticated,
            'is_admin': getattr(request.user, 'is_admin', None),
            'is_manager': getattr(request.user, 'is_manager', None),
            'role_data': getattr(request.user, 'role', {}),
            'role_id': getattr(request.user, 'roleId', None),
            'session_data': dict(request.session),
        }
        return render(request, 'dispatch/debug_auth.html', context)

@method_decorator(login_required_api, name='dispatch')
class ParcelListReportView(View):
    """Report showing a list of parcels with filtering options"""
    api_client = WmsApiClient()
    
    def get(self, request):
        # Check if user is admin
        if not hasattr(request.user, 'is_admin_property') or not request.user.is_admin_property:
            messages.error(request, 'Access denied. Reports are only available to administrators.')
            return redirect('dashboard')
            
        context = {}
        branch_filter = None
        
        # Apply branch filter for managers
        if hasattr(request.user, 'is_manager') and request.user.is_manager() and not request.user.is_admin():
            branch_filter = request.user.branch.get('name')
        
        # Get filter parameters
        start_date = request.GET.get('start_date')
        end_date = request.GET.get('end_date')
        destination_filter = request.GET.get('destination_filter')
        branch_filter_param = request.GET.get('branch_filter') or branch_filter
        
        try:
            # Get all parcels
            all_parcels = self.api_client.get_parcels(request, branch=branch_filter_param)
            users = self.api_client.get_users(request)
            user_map = {user['id']: user for user in users}
            
            # Filter by date range and destination if provided
            filtered_parcels = []
            for parcel in all_parcels:
                if parcel.get('createdAt'):
                    parcel_date = parse_iso_datetime(parcel['createdAt'])
                    if parcel_date:
                        parcel_date_only = parcel_date.date()
                        
                        # Apply date filters
                        if start_date and parcel_date_only < datetime.strptime(start_date, '%Y-%m-%d').date():
                            continue
                        if end_date and parcel_date_only > datetime.strptime(end_date, '%Y-%m-%d').date():
                            continue
                        
                        # Apply destination filter
                        if destination_filter and parcel.get('destination') != destination_filter:
                            continue
                        
                        # Add clerk information
                        clerk_id = parcel.get('createdById')
                        clerk_data = user_map.get(clerk_id, {})
                        parcel['clerk_name'] = f"{clerk_data.get('firstName', '')} {clerk_data.get('lastName', '')}".strip()
                        if not parcel['clerk_name']:
                            parcel['clerk_name'] = clerk_data.get('username', f'User {clerk_id}')
                        
                        # Add parsed date for display
                        parcel['parsed_date'] = parcel_date
                        
                        filtered_parcels.append(parcel)
            
            # Get available destinations for filter
            available_destinations = sorted(list(set(p.get('destination', '') for p in all_parcels if p.get('destination'))))
            
            # Calculate totals
            total_parcels = len(filtered_parcels)
            total_amount = sum(Decimal(p.get('amount', 0) or 0) for p in filtered_parcels)
            
            context.update({
                'parcels': filtered_parcels,
                'start_date': start_date,
                'end_date': end_date,
                'destination_filter': destination_filter,
                'branch_filter': branch_filter_param,
                'available_destinations': available_destinations,
                'total_parcels': total_parcels,
                'total_amount': total_amount,
                'page_title': 'Parcel List Report',
                'user': request.user,  # Add user to template context
            })
            
        except Exception as e:
            logger.error(f"Error generating parcel list report: {str(e)}")
            messages.error(request, f"Error generating report: {str(e)}")
            context['parcels'] = []
            context['user'] = request.user  # Add user to error context
        
        return render(request, 'dispatch/reports/parcel_list.html', context)

@method_decorator(login_required_api, name='dispatch')
class ContractCustomerListView(View):
    """View for listing and managing contract customers"""
    
    def get(self, request):
        # Check if user is admin
        if not hasattr(request.user, 'is_admin_property') or not request.user.is_admin_property:
            messages.error(request, 'Access denied. Customer management is only available to administrators.')
            return redirect('dashboard')
        
        customers = ContractCustomer.objects.filter(is_active=True).order_by('name')
        context = {
            'customers': customers,
            'page_title': 'Contract Customers',
            'user': request.user,
        }
        return render(request, 'dispatch/contract_customers.html', context)

@method_decorator(login_required_api, name='dispatch')
class ContractCustomerCreateView(View):
    """View for creating new contract customers"""
    
    def get(self, request):
        # Check if user is admin
        if not hasattr(request.user, 'is_admin_property') or not request.user.is_admin_property:
            messages.error(request, 'Access denied. Customer management is only available to administrators.')
            return redirect('dashboard')
        
        context = {
            'page_title': 'Add Contract Customer',
            'user': request.user,
        }
        return render(request, 'dispatch/contract_customer_form.html', context)
    
    def post(self, request):
        # Check if user is admin
        if not hasattr(request.user, 'is_admin_property') or not request.user.is_admin_property:
            messages.error(request, 'Access denied. Customer management is only available to administrators.')
            return redirect('dashboard')
        
        try:
            # Store API user information instead of Django User foreign key
            api_user_id = None
            api_username = request.user.username if hasattr(request.user, 'username') else 'Unknown'
            
            if hasattr(request.user, 'id'):
                api_user_id = request.user.id
            elif hasattr(request.user, 'roleId'):
                api_user_id = request.user.roleId
            
            customer = ContractCustomer.objects.create(
                name=request.POST.get('name'),
                company_name=request.POST.get('company_name', ''),
                email=request.POST.get('email', ''),
                phone=request.POST.get('phone', ''),
                address=request.POST.get('address', ''),
                contact_person=request.POST.get('contact_person', ''),
                contract_number=request.POST.get('contract_number', ''),
                payment_terms=request.POST.get('payment_terms', 'Net 30'),
                tax_rate=request.POST.get('tax_rate', 0.00),
                api_user_id=api_user_id,
                api_username=api_username
            )
            messages.success(request, f'Contract customer "{customer.name}" created successfully.')
            return redirect('contract_customers')
        except Exception as e:
            messages.error(request, f'Error creating customer: {str(e)}')
            return render(request, 'dispatch/contract_customer_form.html', {
                'page_title': 'Add Contract Customer',
                'user': request.user,
            })

@method_decorator(login_required_api, name='dispatch')
class InvoiceCreateView(View):
    """View for creating invoices for contract customers"""
    api_client = WmsApiClient()
    
    def get(self, request):
        # Check if user is admin
        if not hasattr(request.user, 'is_admin_property') or not request.user.is_admin_property:
            messages.error(request, 'Access denied. Invoice creation is only available to administrators.')
            return redirect('dashboard')
        
        customers = ContractCustomer.objects.filter(is_active=True).order_by('name')
        
        context = {
            'customers': customers,
            'page_title': 'Create Invoice',
            'user': request.user,
        }
        return render(request, 'dispatch/invoice_create.html', context)
    
    def post(self, request):
        # Check if user is admin
        if not hasattr(request.user, 'is_admin_property') or not request.user.is_admin_property:
            messages.error(request, 'Access denied. Invoice creation is only available to administrators.')
            return redirect('dashboard')
        
        try:
            customer_id = request.POST.get('customer')
            start_date = request.POST.get('start_date')
            end_date = request.POST.get('end_date')
            
            if not customer_id or not start_date or not end_date:
                messages.error(request, 'Please provide customer, start date, and end date.')
                return redirect('invoice_create')
            
            customer = ContractCustomer.objects.get(id=customer_id)
            
            # Generate invoice number
            invoice_number = f"INV-{timezone.now().strftime('%Y%m%d')}-{Invoice.objects.count() + 1:04d}"
            
            # Store API user information instead of Django User foreign key
            api_user_id = None
            api_username = request.user.username if hasattr(request.user, 'username') else 'Unknown'
            
            if hasattr(request.user, 'id'):
                api_user_id = request.user.id
            elif hasattr(request.user, 'roleId'):
                api_user_id = request.user.roleId
            
            # Create invoice
            invoice = Invoice.objects.create(
                invoice_number=invoice_number,
                customer=customer,
                issue_date=timezone.now().date(),
                due_date=timezone.now().date() + timezone.timedelta(days=30),
                api_user_id=api_user_id,
                api_username=api_username
            )
            
            # Store invoice data in session for parcel selection
            request.session['current_invoice_id'] = invoice.id
            request.session['invoice_customer_id'] = customer_id
            request.session['invoice_start_date'] = start_date
            request.session['invoice_end_date'] = end_date
            
            messages.success(request, f'Invoice {invoice_number} created. Please select parcels to add.')
            return redirect('invoice_parcel_selection')
            
        except Exception as e:
            messages.error(request, f'Error creating invoice: {str(e)}')
            return redirect('invoice_create')

@method_decorator(login_required_api, name='dispatch')
class InvoiceParcelSelectionView(View):
    """View for selecting parcels to add to an invoice"""
    api_client = WmsApiClient()
    
    def get(self, request):
        # Check if user is admin
        if not hasattr(request.user, 'is_admin_property') or not request.user.is_admin_property:
            messages.error(request, 'Access denied. Invoice creation is only available to administrators.')
            return redirect('dashboard')
        
        invoice_id = request.session.get('current_invoice_id')
        if not invoice_id:
            messages.error(request, 'No active invoice found. Please create a new invoice.')
            return redirect('invoice_create')
        
        try:
            invoice = Invoice.objects.get(id=invoice_id)
            customer = invoice.customer
            
            # Get filter parameters from session
            start_date = request.session.get('invoice_start_date')
            end_date = request.session.get('invoice_end_date')
            
            # Get destination filter from request (for dynamic filtering)
            destination_filter = request.GET.get('destination', '')
            
            # Get parcels from API
            all_parcels = self.api_client.get_parcels(request)
            
            # Filter parcels
            filtered_parcels = []
            for parcel in all_parcels:
                if parcel.get('paymentMethods', '').lower() == 'contract':
                    if parcel.get('createdAt'):
                        parcel_date = parse_iso_datetime(parcel['createdAt'])
                        if parcel_date:
                            parcel_date_only = parcel_date.date()
                            
                            # Apply date filters
                            if start_date and parcel_date_only < datetime.strptime(start_date, '%Y-%m-%d').date():
                                continue
                            if end_date and parcel_date_only > datetime.strptime(end_date, '%Y-%m-%d').date():
                                continue
                            
                            # Apply destination filter (dynamic from request)
                            if destination_filter and parcel.get('destination') != destination_filter:
                                continue
                            
                            parcel['parsedCreatedAt'] = parcel_date
                            filtered_parcels.append(parcel)
            
            # Get already added parcels
            added_parcel_ids = list(invoice.items.values_list('parcel_id', flat=True))
            
            # Get available destinations for display
            available_destinations = sorted(list(set(p.get('destination', '') for p in all_parcels if p.get('destination'))))
            
            context = {
                'invoice': invoice,
                'customer': customer,
                'parcels': filtered_parcels,
                'added_parcel_ids': added_parcel_ids,
                'start_date': start_date,
                'end_date': end_date,
                'destination_filter': destination_filter,
                'available_destinations': available_destinations,
                'page_title': f'Select Parcels for Invoice {invoice.invoice_number}',
                'user': request.user,
            }
            return render(request, 'dispatch/invoice_parcel_selection.html', context)
            
        except Exception as e:
            messages.error(request, f'Error loading parcels: {str(e)}')
            return redirect('invoice_create')
    
    def post(self, request):
        # Check if user is admin
        if not hasattr(request.user, 'is_admin_property') or not request.user.is_admin_property:
            messages.error(request, 'Access denied. Invoice creation is only available to administrators.')
            return redirect('dashboard')
        
        try:
            invoice_id = request.session.get('current_invoice_id')
            invoice = Invoice.objects.get(id=invoice_id)
            
            action = request.POST.get('action')
            
            if action == 'add_parcel':
                parcel_id = request.POST.get('parcel_id')
                waybill_number = request.POST.get('waybill_number')
                description = request.POST.get('description')
                quantity = int(request.POST.get('quantity', 1))
                unit_price = Decimal(request.POST.get('unit_price', 0))
                total_price = Decimal(request.POST.get('total_price', 0))
                
                # Check if parcel already added
                if not invoice.items.filter(parcel_id=parcel_id).exists():
                    InvoiceItem.objects.create(
                        invoice=invoice,
                        parcel_id=parcel_id,
                        waybill_number=waybill_number,
                        description=description,
                        quantity=quantity,
                        unit_price=unit_price,
                        total_price=total_price
                    )
                    
                    # Update invoice totals
                    invoice.subtotal = sum(item.total_price for item in invoice.items.all())
                    invoice.tax_amount = invoice.subtotal * (invoice.customer.tax_rate / 100)
                    invoice.save()
                    
                    messages.success(request, f'Parcel {waybill_number} added to invoice.')
                else:
                    messages.warning(request, f'Parcel {waybill_number} is already in the invoice.')
            
            elif action == 'remove_parcel':
                item_id = request.POST.get('item_id')
                item = invoice.items.get(id=item_id)
                waybill_number = item.waybill_number
                item.delete()
                
                # Update invoice totals
                invoice.subtotal = sum(item.total_price for item in invoice.items.all())
                invoice.tax_amount = invoice.subtotal * (invoice.customer.tax_rate / 100)
                invoice.save()
                
                messages.success(request, f'Parcel {waybill_number} removed from invoice.')
            
            elif action == 'search_waybill':
                waybill_number = request.POST.get('waybill_number', '').strip()
                if waybill_number:
                    # Search for parcel by waybill number
                    try:
                        parcel = self.api_client.get_parcel_by_waybill(request, waybill_number)
                        if parcel and parcel.get('paymentMethods', '').lower() == 'contract':
                            # Check if parcel is already in invoice
                            if not invoice.items.filter(parcel_id=parcel['id']).exists():
                                # Add parcel to invoice
                                InvoiceItem.objects.create(
                                    invoice=invoice,
                                    parcel_id=parcel['id'],
                                    waybill_number=parcel['waybillNumber'],
                                    description=parcel.get('description', ''),
                                    quantity=parcel.get('quantity', 1),
                                    unit_price=Decimal(parcel.get('amount', 0) or 0),
                                    total_price=Decimal(parcel.get('totalAmount', 0) or 0)
                                )
                                
                                # Update invoice totals
                                invoice.subtotal = sum(item.total_price for item in invoice.items.all())
                                invoice.tax_amount = invoice.subtotal * (invoice.customer.tax_rate / 100)
                                invoice.save()
                                
                                messages.success(request, f'Parcel {waybill_number} found and added to invoice.')
                            else:
                                messages.warning(request, f'Parcel {waybill_number} is already in the invoice.')
                        else:
                            messages.error(request, f'Parcel {waybill_number} not found or is not a contract parcel.')
                    except Exception as e:
                        messages.error(request, f'Error searching for parcel: {str(e)}')
                else:
                    messages.error(request, 'Please enter a waybill number to search.')
            
            return redirect('invoice_parcel_selection')
            
        except Exception as e:
            messages.error(request, f'Error processing request: {str(e)}')
            return redirect('invoice_parcel_selection')

@method_decorator(login_required_api, name='dispatch')
class InvoiceDetailView(View):
    """View for displaying invoice details and generating PDF"""
    
    def get(self, request, invoice_id):
        # Check if user is admin
        if not hasattr(request.user, 'is_admin_property') or not request.user.is_admin_property:
            messages.error(request, 'Access denied. Invoice details are only available to administrators.')
            return redirect('dashboard')
        
        try:
            invoice = Invoice.objects.get(id=invoice_id)
            context = {
                'invoice': invoice,
                'customer': invoice.customer,
                'items': invoice.items.all(),
                'page_title': f'Invoice {invoice.invoice_number}',
                'user': request.user,
            }
            return render(request, 'dispatch/invoice_detail.html', context)
        except Invoice.DoesNotExist:
            messages.error(request, 'Invoice not found.')
            return redirect('invoice_list')

@method_decorator(login_required_api, name='dispatch')
class InvoiceListView(View):
    """View for listing all invoices"""
    
    def get(self, request):
        # Check if user is admin
        if not hasattr(request.user, 'is_admin_property') or not request.user.is_admin_property:
            messages.error(request, 'Access denied. Invoice management is only available to administrators.')
            return redirect('dashboard')
        
        invoices = Invoice.objects.all().order_by('-created_at')
        context = {
            'invoices': invoices,
            'page_title': 'Invoices',
            'user': request.user,
        }
        return render(request, 'dispatch/invoice_list.html', context)

@method_decorator(login_required_api, name='dispatch')
class InvoicePrintView(View):
    """View for printing invoices"""
    
    def get(self, request, invoice_id):
        # Check if user is admin
        if not hasattr(request.user, 'is_admin_property') or not request.user.is_admin_property:
            messages.error(request, 'Access denied. Invoice printing is only available to administrators.')
            return redirect('dashboard')
        
        try:
            invoice = Invoice.objects.get(id=invoice_id)
            context = {
                'invoice': invoice,
                'customer': invoice.customer,
                'items': invoice.items.all(),
                'company_name': 'Ficma Home Logistics',
                'company_email': 'ficmahomelogistics19@gmail.com',
                'company_phone': '+254707136852',
                'page_title': f'Invoice {invoice.invoice_number}',
                'user': request.user,
            }
            return render(request, 'dispatch/invoice_print.html', context)
        except Invoice.DoesNotExist:
            messages.error(request, 'Invoice not found.')
            return redirect('invoice_list')
