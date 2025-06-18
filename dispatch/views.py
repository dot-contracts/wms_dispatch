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

from .models import Branch, UserProfile
from .api_client import WmsApiClient
from .auth_backend import ApiAuthenticationBackend
from .middleware import login_user, logout_user, login_required_api, is_authenticated

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
            }
        
        except Exception as e:
            logger.error(f"Error loading dashboard: {str(e)}")
            messages.error(request, "Error loading dashboard data")
            return render(request, 'dispatch/dashboard.html', {})
        return render(request, 'dispatch/dashboard.html', context)


class ParcelListView(View):
    def get(self, request):
        """List all parcels from the API with filtering support"""
        api_client = WmsApiClient()
        
        branch_filter = None
        # Apply branch filter for managers, but not for admins
        if hasattr(request.user, 'is_manager') and request.user.is_manager() and not request.user.is_admin():
            branch_filter = request.user.branch.get('name')
            
        try:
            # Get filter parameters from request
            status_filter = request.GET.get('status')
            date_filter = request.GET.get('date')
            destination_filter = request.GET.get('destination')
            payment_mode_filter = request.GET.get('payment_mode')

            # Get all parcels from API, filtered by branch if applicable
            parcels = api_client.get_parcels(request, branch=branch_filter)

            # Apply filters
            filtered_parcels = parcels
            if status_filter:
                filtered_parcels = [p for p in filtered_parcels if str(p.get('status')) == status_filter]
            if date_filter:
                filtered_parcels = [p for p in filtered_parcels if p.get('createdAt', '').startswith(date_filter)]
            if destination_filter:
                filtered_parcels = [p for p in filtered_parcels if p.get('destination') == destination_filter]
            if payment_mode_filter:
                filtered_parcels = [p for p in filtered_parcels if p.get('paymentMethods') == payment_mode_filter]

            # Get unique values for filter dropdowns
            destinations = sorted(set(p.get('destination') for p in parcels if p.get('destination')))
            payment_methods = sorted(set(p.get('paymentMethods') for p in parcels if p.get('paymentMethods')))
            
            # Status choices mapping
            status_choices = [
                (0, 'Pending'),
                (1, 'Finalized'),
                (2, 'In Transit'),
                (3, 'Delivered'),
                (4, 'Cancelled')
            ]

            context = {
                'parcels': filtered_parcels,
                'status_choices': status_choices,
                'destinations': destinations,
                'payment_methods': payment_methods,
                'status_filter': status_filter,
                'date_filter': date_filter,
                'destination_filter': destination_filter,
                'payment_mode_filter': payment_mode_filter,
            }

            return render(request, 'dispatch/parcel_list.html', context)
        except Exception as e:
            logger.error(f"Error loading parcels: {str(e)}")
            messages.error(request, "Error loading parcels")
            return render(request, 'dispatch/parcel_list.html', {'parcels': []})

class ParcelDetailView(View):
    def get(self, request, parcel_id):
        """Show details of a specific parcel"""
        api_client = WmsApiClient()
        try:
            parcel = api_client.get_parcel_by_id(parcel_id, request)

            # Parse date fields if they exist
            if parcel and 'createdAt' in parcel and isinstance(parcel['createdAt'], str):
                parcel['createdAt'] = parse_iso_datetime(parcel['createdAt'])
            if parcel and 'dispatchedAt' in parcel and isinstance(parcel['dispatchedAt'], str):
                 parcel['dispatchedAt'] = parse_iso_datetime(parcel['dispatchedAt'])

            return render(request, 'dispatch/parcel_detail.html', {'parcel': parcel, 'requested_parcel_id': parcel_id})
        except Exception as e:
            logger.error(f"Error loading parcel {parcel_id}: {str(e)}")
            messages.error(request, "Error loading parcel details")
            return redirect('parcel_list')

class DispatchListView(View):
    def get(self, request):
        """List all dispatches from the API"""
        api_client = WmsApiClient()

        branch_filter = None
        # Apply branch filter for managers, but not for admins
        if hasattr(request.user, 'is_manager') and request.user.is_manager() and not request.user.is_admin():
            branch_filter = request.user.branch.get('name')

        try:
            raw_dispatches = api_client.get_dispatches(request=request, branch=branch_filter)

            # Process the raw data to match template expectations
            dispatches = []
            for dispatch_data in raw_dispatches:
                # Map API fields to template expected fields
                processed_dispatch = {
                    'id': dispatch_data.get('id'),
                    'dispatch_code': dispatch_data.get('id'), # Using ID as code for now
                    'destination': dispatch_data.get('sourceBranch', 'N/A'),
                    'dispatch_date': dispatch_data.get('dispatchTime'), # Keep as string for now, format in template
                    'total_parcels': len(dispatch_data.get('parcelIds', [])), # Calculate count
                    # 'total_amount': 'N/A', # API list endpoint doesn't provide total amount
                    'status': dispatch_data.get('status', 'unknown'), # Use the string status
                }
                dispatches.append(processed_dispatch)

            # Sort dispatches by date if needed (API already orders by time descending)
            # dispatches.sort(key=lambda x: x.get('dispatch_date', ''), reverse=True)

            return render(request, 'dispatch/dispatch_list.html', {'dispatches': dispatches})
        except Exception as e:
            logger.error(f"Error loading dispatches: {str(e)}")
            messages.error(request, "Error loading dispatches")
            return render(request, 'dispatch/dispatch_list.html', {'dispatches': []})

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
            
            # Extract parcels from the response structure
            parcels_container = dispatch_data.get('parcels', {})
            parcels_list = parcels_container.get('$values', []) if isinstance(parcels_container, dict) else []
            
            # Parse dispatch date
            dispatch_date_str = dispatch_data.get('dispatchTime')
            dispatch_date = parse_iso_datetime(dispatch_date_str) if dispatch_date_str else None
            
            # Create dispatch context
            dispatch = {
                'id': dispatch_data.get('dispatchId'),
                'dispatch_code': dispatch_data.get('dispatchId'),
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
                'dispatch_parcels': dispatch_parcels
            }
            
            return render(request, 'dispatch/dispatch_detail.html', context)
        except Exception as e:
            logger.error(f"Error loading dispatch {dispatch_id}: {str(e)}", exc_info=True)
            messages.error(request, "Error loading dispatch details")
            return redirect('dispatch_list')

@method_decorator(login_required_api, name='dispatch')
class CreateDispatchView(View):
    def get(self, request):
        """Show form to create a new dispatch"""
        api_client = WmsApiClient()
        date_filter_value = request.GET.get('date_filter')
        
        branch_filter = None
        # Apply branch filter for managers, but not for admins
        if hasattr(request.user, 'is_manager') and request.user.is_manager() and not request.user.is_admin():
            branch_filter = request.user.branch.get('name')

        try:
            if date_filter_value:
                logger.info(f"Loading create dispatch view with date filter: {date_filter_value}")
            else:
                logger.info("Loading create dispatch view without date filter")
                
            pending_parcels = api_client.get_pending_parcels(
                date_filter=date_filter_value, 
                request=request,
                branch=branch_filter
            )
            
            # --- Debugging Destination Extraction ---
            logger.info(f"Processing {len(pending_parcels)} pending parcels for destination extraction.")
            destinations_list = []
            for i, parcel in enumerate(pending_parcels):
                destination = parcel.get('destination')
                if destination:
                    destinations_list.append(destination)
                    # Log a few successful extractions
                    if i < 5:
                         logger.info(f"Parcel {i}: Extracted destination '{destination}'")
                else:
                    # Log parcels where destination is missing or None
                    if i < 5:
                        logger.warning(f"Parcel {i}: Destination missing or None. Parcel keys: {list(parcel.keys())}")
                        
            available_destinations = sorted(set(destinations_list))
            logger.info(f"Extracted unique destinations: {available_destinations}")
            # --- End Debugging ---

            if date_filter_value:
                logger.info(f"Retrieved {len(pending_parcels)} pending parcels for date {date_filter_value}")
            else:
                logger.info(f"Retrieved {len(pending_parcels)} total pending parcels")

            context = {
                'parcels': pending_parcels,
                'date_filter_value': date_filter_value,
                'available_destinations': available_destinations,
            }
            return render(request, 'dispatch/create_dispatch.html', context)
        except Exception as e:
            logger.error(f"Error loading pending parcels: {str(e)}")
            messages.error(request, "Error loading pending parcels")
        return render(request, 'dispatch/create_dispatch.html', {
                'parcels': [], 
                'date_filter_value': date_filter_value,
                'available_destinations': []
        })
    
    def post(self, request):
        """Create a new dispatch through the API"""
        api_client = WmsApiClient()
        try:
            # Get form data
            parcel_ids = request.POST.getlist('parcel_ids')
            destination = request.POST.get('destination')
            vehicle_number = request.POST.get('vehicle_registration')
            driver_name = request.POST.get('driver_name')
            
            # Validate input fields
            if not parcel_ids:
                messages.error(request, "No parcels selected for dispatch.")
                return redirect('create_dispatch')
            if not destination:
                messages.error(request, "Destination is required.")
                return redirect('create_dispatch')
            if not vehicle_number:
                messages.error(request, "Vehicle registration is required.")
                return redirect('create_dispatch')
            if not driver_name:
                messages.error(request, "Driver name is required.")
                return redirect('create_dispatch')
            
            # Fetch full parcel details for the selected parcels
            selected_parcels_details = []
            for parcel_id in parcel_ids:
                try:
                    parcel_detail = api_client.get_parcel_by_id(parcel_id, request)
                    if parcel_detail:
                        # Filter to include only necessary fields
                        filtered_parcel = {
                            'id': parcel_detail.get('id'),
                            'waybillNumber': parcel_detail.get('waybillNumber'),
                            'status': parcel_detail.get('status', 0),
                            'destination': parcel_detail.get('destination'),
                            'sender': parcel_detail.get('sender'),
                            'receiver': parcel_detail.get('receiver'),
                            'senderTelephone': parcel_detail.get('senderTelephone'),
                            'receiverTelephone': parcel_detail.get('receiverTelephone'),
                            'quantity': parcel_detail.get('quantity', 1),
                            'description': parcel_detail.get('description'),
                            'amount': parcel_detail.get('amount', 0),
                            'paymentMethods': parcel_detail.get('paymentMethods')
                        }
                        selected_parcels_details.append(filtered_parcel)
                        logger.info(f"Fetched parcel {parcel_id}: {filtered_parcel}")
                    else:
                        logger.warning(f"Could not fetch details for parcel ID: {parcel_id}")
                except Exception as e:
                    logger.error(f"Error fetching detail for parcel {parcel_id}: {str(e)}")
                    pass

            if not selected_parcels_details:
                messages.error(request, "Failed to fetch details for selected parcels.")
                return redirect('create_dispatch')

            # Format dispatch data according to API expectations
            dispatch_data = {
                'sourceBranch': destination,
                'vehicleNumber': vehicle_number,
                'driver': driver_name,
                'ParcelIds': parcel_ids,
                'Parcels': selected_parcels_details,
                'status': 'in_transit',
                'dispatchTime': datetime.utcnow().isoformat() + 'Z'
            }

            logger.info(f"Attempting to create dispatch with data: {json.dumps(dispatch_data, indent=2)}")

            # Create dispatch through API
            dispatch = api_client.create_dispatch(dispatch_data, request)

            # Update parcel statuses to "IN TRANSIT" (status=2)
            try:
                parcel_ids_to_update = [p.get('id') for p in selected_parcels_details if p.get('id')]
                if parcel_ids_to_update:
                    logger.info(f"Attempting to update statuses for {len(parcel_ids_to_update)} parcels to In Transit (2).")
                    api_client.update_parcels_status_batch(parcel_ids_to_update, 2, request)
                    logger.info(f"Updated {len(parcel_ids_to_update)} parcels to In Transit status")
                else:
                    logger.warning("No valid parcel IDs found to update status after dispatch creation.")
            except Exception as e:
                logger.error(f"Error updating parcel statuses after dispatch creation: {str(e)}")
                messages.warning(request, "Dispatch created but failed to update parcel statuses.")

            messages.success(request, "Dispatch created successfully.")
            new_dispatch_id = dispatch.get('id')
            if new_dispatch_id:
                return redirect('dispatch_detail', dispatch_id=new_dispatch_id)
            else:
                logger.error("Dispatch creation successful but no dispatch ID returned by API.")
                messages.warning(request, "Dispatch created, but could not retrieve dispatch details.")
                return redirect('dispatch_list')

        except Exception as e:
            logger.error(f"Error creating dispatch: {str(e)}", exc_info=True)
            messages.error(request, f"Error creating dispatch: {str(e)}")
            return redirect('create_dispatch')

class ConsignmentNoteView(View):
    @method_decorator(login_required_api)
    def dispatch(self, *args, **kwargs):
        return super().dispatch(*args, **kwargs)
        
    def get(self, request, parcel_id):
        """Show printable consignment note for a specific parcel"""
        api_client = WmsApiClient()
        try:
            # Validate parcel_id is a valid UUID
            try:
                uuid.UUID(str(parcel_id))
            except ValueError:
                messages.error(request, "Invalid parcel ID format")
                return redirect('parcel_list')

            parcel = api_client.get_parcel_by_id(parcel_id, request)
            if not parcel:
                messages.error(request, "Parcel not found")
                return redirect('parcel_list')

            # Parse date fields if they exist
            if parcel and 'createdAt' in parcel and isinstance(parcel['createdAt'], str):
                parcel['createdAt'] = parse_iso_datetime(parcel['createdAt'])
            if parcel and 'dispatchedAt' in parcel and isinstance(parcel['dispatchedAt'], str):
                parcel['dispatchedAt'] = parse_iso_datetime(parcel['dispatchedAt'])

            return render(request, 'dispatch/consignment_note.html', {'parcel': parcel})
        except requests.exceptions.HTTPError as e:
            if e.response.status_code == 404:
                messages.error(request, "Parcel not found")
            else:
                messages.error(request, f"Error loading consignment note: {str(e)}")
            return redirect('parcel_list')
        except Exception as e:
            logger.error(f"Error loading consignment note for parcel {parcel_id}: {str(e)}")
            messages.error(request, "Error loading consignment note")
            return redirect('parcel_list')

class DispatchNoteView(View):
    @method_decorator(login_required_api)
    def dispatch(self, *args, **kwargs):
        return super().dispatch(*args, **kwargs)
        
    def get(self, request, dispatch_id):
        """Show dispatch note with all parcels"""
        api_client = WmsApiClient()
        try:
            # Get dispatch note from API
            dispatch_data = api_client.get_dispatch_note(dispatch_id, request)
            logger.info(f"Received dispatch data: {dispatch_data}")
            
            if not dispatch_data:
                messages.error(request, "No dispatch data received")
                return redirect('dispatch_list')
            
            # Extract parcels from the response structure
            parcels_container = dispatch_data.get('parcels', {})
            parcels_list = parcels_container.get('$values', []) if isinstance(parcels_container, dict) else []
            
            # Create dispatch context
            dispatch = {
                'id': dispatch_data.get('dispatchId'),
                'dispatch_code': dispatch_data.get('dispatchId'),
                'destination': dispatch_data.get('sourceBranch'),
                'dispatch_date': dispatch_data.get('dispatchTime'),
                'total_parcels': len(parcels_list),
                'vehicle_registration': dispatch_data.get('vehicleNumber'),
                'driver_name': dispatch_data.get('driver'),
                'status': dispatch_data.get('status', 'in_transit').lower()
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
                        'waybill_number': parcel.get('waybillNumber'),
                        'qr_code': parcel.get('qrCode'),
                        'sender': parcel.get('sender'),
                        'sender_telephone': parcel.get('senderTelephone'),
                        'receiver': parcel.get('receiver'),
                        'receiver_telephone': parcel.get('receiverTelephone'),
                        'description': parcel.get('description'),
                        'quantity': parcel.get('quantity', 1),
                        'total_amount': parcel.get('amount', 0),
                        'payment_methods': parcel.get('paymentMethods', 'N/A')
                    }
                }
                dispatch_parcels.append(formatted_parcel)
            
            # Calculate payment method totals
            total_cod_amount = sum(
                p['parcel']['total_amount'] for p in dispatch_parcels 
                if p['parcel']['payment_methods'].lower() == 'cod'
            )
            total_paid_amount = sum(
                p['parcel']['total_amount'] for p in dispatch_parcels 
                if p['parcel']['payment_methods'].lower() == 'paid'
            )
            total_contract_amount = sum(
                p['parcel']['total_amount'] for p in dispatch_parcels 
                if p['parcel']['payment_methods'].lower() == 'contract'
            )
            
            context = {
                'dispatch': dispatch,
                'dispatch_parcels': dispatch_parcels,
                'total_cod_amount': total_cod_amount,
                'total_paid_amount': total_paid_amount,
                'total_contract_amount': total_contract_amount,
                'calculated_overall_total': total_amount
            }
            
            return render(request, 'dispatch/dispatch_note.html', context)
        except Exception as e:
            logger.error(f"Error loading dispatch note {dispatch_id}: {str(e)}", exc_info=True)
            messages.error(request, "Error loading dispatch note")
            return redirect('dispatch_list')
