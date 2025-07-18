import requests
import json
from django.conf import settings
from datetime import datetime
from decimal import Decimal
import logging
import uuid
import random
from django.utils import timezone
import hashlib

# Set up logger
logger = logging.getLogger(__name__)

class WmsApiClient:
    def __init__(self):
        self.base_url = settings.API_BASE_URL
        self.headers = {
            'Content-Type': 'application/json',
            'Accept': 'application/json',
        }
    
    def _get_headers(self, request=None):
        """Get headers with API token if available"""
        headers = self.headers.copy()
        if request and 'api_token' in request.session:
            headers['Authorization'] = f'Bearer {request.session["api_token"]}'
        return headers
    
    def get_parcels(self, request=None, branch=None):
        """Get all parcels from the API"""
        try:
            url = f"{self.base_url}/api/parcels"
            params = {}
            if branch:
                params['branchName'] = branch
            
            logger.info(f"Attempting to get parcels from {url} with params {params}")
            response = requests.get(
                url, 
                headers=self._get_headers(request), 
                params=params,
                timeout=15
            )
            response.raise_for_status()
            raw_data_from_api = response.json()

            # *** START DEBUG LOGGING ***
            # Log the overall structure type
            logger.info(f"API response type: {type(raw_data_from_api)}")
            
            # If it's the expected dict with '$values', log a sample from '$values'
            if isinstance(raw_data_from_api, dict) and "$values" in raw_data_from_api:
                parcel_list_candidate = raw_data_from_api.get("$values")
                if isinstance(parcel_list_candidate, list) and parcel_list_candidate:
                    logger.info(f"Sample parcel data from API ($values[0]): {str(parcel_list_candidate[0])[:1000]}") # Log first parcel
            elif isinstance(raw_data_from_api, list) and raw_data_from_api:
                 logger.info(f"Sample parcel data from API (list[0]): {str(raw_data_from_api[0])[:1000]}") # Log first parcel
            # *** END DEBUG LOGGING ***

            # Check if the data is in the { "$id": ..., "$values": [...] } format
            if isinstance(raw_data_from_api, dict) and "$values" in raw_data_from_api and isinstance(raw_data_from_api["$values"], list):
                processed_data = raw_data_from_api["$values"]
                logger.info(f"Successfully retrieved {len(processed_data)} parcels from API (extracted from '$values')")
            elif isinstance(raw_data_from_api, list):
                processed_data = raw_data_from_api
                logger.info(f"Successfully retrieved {len(processed_data)} parcels from API (direct list)")
            else:
                logger.warning(f"API returned data in an unexpected format: {type(raw_data_from_api)}. Raw data: {str(raw_data_from_api)[:200]}...")
                processed_data = []
            return processed_data
        except requests.exceptions.RequestException as e:
            logger.error(f"Error connecting to API: {str(e)}")
            
            # Check if we should use mock data for development/testing
            use_mock = getattr(settings, 'USE_MOCK_DATA', False)
            if use_mock:
                logger.warning("Falling back to mock data since API is unavailable")
                return self.get_mock_parcels()
                
            raise Exception(f"Failed to connect to WMS API: {str(e)}")
        except json.JSONDecodeError as e:
            logger.error(f"Error parsing API response: {str(e)}")
            raise Exception(f"Invalid response from WMS API: {str(e)}")
        except Exception as e:
            logger.error(f"Unexpected error: {str(e)}")
            raise Exception(f"An unexpected error occurred: {str(e)}")
    
    def get_mock_parcels(self):
        """Generate mock parcels for development/testing"""
        destinations = ['Nairobi', 'Mombasa', 'Kisumu', 'Nakuru', 'Eldoret']
        descriptions = ['Documents', 'Package', 'Electronics', 'Clothing', 'Perishables']
        payment_methods = ['Cash', 'M-Pesa', 'Bank Transfer']
        
        mock_parcels = []
        
        # Generate 10 mock parcels
        for i in range(10):
            parcel_id = str(uuid.uuid4())
            amount = random.randint(500, 5000)
            quantity = random.randint(1, 5)
            rate = amount / quantity
            
            mock_parcel = {
                'id': parcel_id,
                'createdAt': timezone.now().isoformat(),
                'waybillNumber': f'WB-{random.randint(10000, 99999)}',
                'qrCode': f'QR-{parcel_id[:8]}',
                'dispatchedAt': None,
                'dispatchTrackingCode': None,
                'sender': f'Sender {i+1}',
                'senderTelephone': f'07{random.randint(10000000, 99999999)}',
                'receiver': f'Receiver {i+1}',
                'receiverTelephone': f'07{random.randint(10000000, 99999999)}',
                'destination': random.choice(destinations),
                'quantity': quantity,
                'description': random.choice(descriptions),
                'amount': amount,
                'rate': rate,
                'paymentMethods': random.choice(payment_methods),
                'totalAmount': amount,
                'totalRate': rate * quantity,
                'status': random.randint(0, 3),
                'createdById': random.choice([1, 2, 8, 3, 4, 5, 6]),
                'createdBy': None
            }
            
            mock_parcels.append(mock_parcel)
            
        return mock_parcels
    
    def get_parcel_by_id(self, parcel_id, request=None):
        """Get a parcel by its ID"""
        try:
            logger.info(f"Attempting to get parcel {parcel_id} from {self.base_url}/api/parcels/{parcel_id}")
            response = requests.get(
                f"{self.base_url}/api/parcels/{parcel_id}", 
                headers=self._get_headers(request),
                timeout=15
            )
            response.raise_for_status()
            parcel_data = response.json()
            logger.info(f"Successfully retrieved parcel {parcel_id} from API")
            return parcel_data
        except requests.exceptions.RequestException as e:
            logger.error(f"Error connecting to API for parcel {parcel_id}: {str(e)}")
            
            # Check if we should use mock data for development/testing
            use_mock = getattr(settings, 'USE_MOCK_DATA', False)
            if use_mock:
                logger.warning(f"Falling back to mock data for parcel {parcel_id} since API is unavailable")
                return self.get_mock_parcel_by_id(parcel_id)
                
            raise Exception(f"Failed to connect to WMS API for parcel {parcel_id}: {str(e)}")
        except json.JSONDecodeError as e:
            logger.error(f"Error parsing API response for parcel {parcel_id}: {str(e)}")
            raise Exception(f"Invalid response from WMS API for parcel {parcel_id}: {str(e)}")
        except Exception as e:
            logger.error(f"Unexpected error fetching parcel {parcel_id}: {str(e)}")
            raise Exception(f"An unexpected error occurred fetching parcel {parcel_id}: {str(e)}")

    def get_mock_parcel_by_id(self, parcel_id):
        """Generate a mock parcel by ID for development/testing"""
        # First try to find the parcel in existing mock data
        mock_parcels = self.get_mock_parcels()
        for parcel in mock_parcels:
            if str(parcel['id']) == str(parcel_id):
                return parcel
        
        # If not found, generate a new mock parcel with the requested ID
        destinations = ['Nairobi', 'Mombasa', 'Kisumu', 'Nakuru', 'Eldoret']
        descriptions = ['Documents', 'Package', 'Electronics', 'Clothing', 'Perishables']
        payment_methods = ['Cash', 'M-Pesa', 'Bank Transfer']
        
        amount = random.randint(500, 5000)
        quantity = random.randint(1, 5)
        rate = amount / quantity
        
        mock_parcel = {
            'id': str(parcel_id),
            'createdAt': timezone.now().isoformat(),
            'waybillNumber': f'WB-{random.randint(10000, 99999)}',
            'qrCode': f'QR-{str(parcel_id)[:8]}',
            'dispatchedAt': None,
            'dispatchTrackingCode': None,
            'sender': f'Mock Sender {random.randint(1, 10)}',
            'senderTelephone': f'07{random.randint(10000000, 99999999)}',
            'receiver': f'Mock Receiver {random.randint(1, 10)}',
            'receiverTelephone': f'07{random.randint(10000000, 99999999)}',
            'destination': random.choice(destinations),
            'quantity': quantity,
            'description': random.choice(descriptions),
            'amount': amount,
            'rate': rate,
            'paymentMethods': random.choice(payment_methods),
            'totalAmount': amount,
            'totalRate': rate * quantity,
            'status': random.randint(0, 3),
            'createdById': 8,
            'createdBy': None
        }
        
        return mock_parcel
    
    def get_users(self, request=None):
        """Get all users from the API"""
        try:
            url = f"{self.base_url}/api/users"
            logger.info(f"Attempting to get users from {url}")
            response = requests.get(
                url,
                headers=self._get_headers(request),
                timeout=10
            )
            response.raise_for_status()
            raw_data_from_api = response.json()

            if isinstance(raw_data_from_api, dict) and "$values" in raw_data_from_api:
                return raw_data_from_api["$values"]
            elif isinstance(raw_data_from_api, list):
                return raw_data_from_api
            else:
                logger.warning("Users API returned data in an unexpected format.")
                return []
        except requests.exceptions.RequestException as e:
            logger.error(f"Error connecting to users API: {str(e)}")
            use_mock = getattr(settings, 'USE_MOCK_DATA', False)
            if use_mock:
                logger.warning("Falling back to mock users data.")
                return self.get_mock_users()
            raise Exception(f"Failed to connect to WMS API for users: {str(e)}")

    def get_mock_users(self):
        """Generate mock users for development/testing"""
        return [
            {'id': 1, 'username': 'admin_user', 'firstName': 'Admin', 'lastName': 'User'},
            {'id': 2, 'username': 'manager_user', 'firstName': 'Manager', 'lastName': 'User'},
            {'id': 8, 'username': 'clerk_paul', 'firstName': 'Paul', 'lastName': 'Clerk'},
            {'id': 3, 'username': 'nairobi_manager', 'firstName': 'Nairobi', 'lastName': 'Manager'},
            {'id': 4, 'username': 'mombasa_manager', 'firstName': 'Mombasa', 'lastName': 'Manager'},
            {'id': 5, 'username': 'kisumu_manager', 'firstName': 'Kisumu', 'lastName': 'Manager'},
            {'id': 6, 'username': 'regular_user', 'firstName': 'Regular', 'lastName': 'User'},
        ]
    
    def get_parcel_by_waybill(self, waybill_number, request=None):
        """Get a parcel by its waybill number"""
        response = requests.get(
            f"{self.base_url}/api/parcels/waybill/{waybill_number}", 
            headers=self._get_headers(request)
        )
        response.raise_for_status()
        return response.json()
    
    def get_pending_parcels(self, date_filter=None, request=None, branch=None):
        """Get all pending parcels, optionally filtered by creation date or branch"""
        try:
            url = f"{self.base_url}/api/parcels/pending"
            params = {}
            if branch:
                params['branchName'] = branch

            logger.info(f"Fetching pending parcels from API with params: {params}")

            response = requests.get(url, headers=self._get_headers(request), params=params, timeout=15)
            response.raise_for_status()
            data = response.json()
            
            # Get all parcels
            parcels = data.get("$values", []) if isinstance(data, dict) and "$values" in data else data
            
            if date_filter:
                # Filter parcels by date on the client side
                filtered_parcels = []
                for parcel in parcels:
                    created_at = parcel.get('createdAt')
                    if created_at:
                        try:
                            # Parse the ISO datetime string
                            parcel_date = datetime.fromisoformat(created_at.replace('Z', '+00:00'))
                            # Compare only the date part
                            if parcel_date.date().isoformat() == date_filter:
                                filtered_parcels.append(parcel)
                        except (ValueError, AttributeError) as e:
                            logger.warning(f"Could not parse date for parcel {parcel.get('id')}: {str(e)}")
                
                logger.info(f"Client-side filtering: Found {len(filtered_parcels)} parcels matching date {date_filter}")
                if filtered_parcels:
                    sample_size = min(5, len(filtered_parcels))
                    sample_dates = [p.get('createdAt', 'No date') for p in filtered_parcels[:sample_size]]
                    logger.info(f"Sample of filtered parcel creation dates: {sample_dates}")
                return filtered_parcels
            else:
                logger.info(f"Found {len(parcels)} total pending parcels")
                return parcels
                
        except requests.exceptions.RequestException as e:
            logger.error(f"Error fetching pending parcels: {str(e)}")
            
            # Check if we should use mock data for development/testing
            use_mock = getattr(settings, 'USE_MOCK_DATA', False)
            if use_mock:
                logger.warning("Falling back to mock pending parcels since API is unavailable")
                mock_parcels = self.get_mock_parcels()
                # Filter to only pending parcels (status 0 or 1)
                return [p for p in mock_parcels if p['status'] in [0, 1]]
                
            raise Exception(f"Failed to fetch pending parcels: {str(e)}")
    
    def get_parcel_count_for_date(self, date, request=None, branch=None):
        """Get the number of parcels created on a specific date"""
        try:
            url = f"{self.base_url}/api/Parcels/count"
            params = {'date': date.isoformat()}
            if branch:
                params['branchName'] = branch
                
            response = requests.get(url, headers=self._get_headers(request), params=params, timeout=10)
            response.raise_for_status()
            return response.json().get('count', 0)
        except requests.exceptions.RequestException as e:
            logger.error(f"Error fetching parcel count from API: {str(e)}")
            use_mock = getattr(settings, 'USE_MOCK_DATA', False)
            if use_mock:
                return self.get_mock_parcel_count_for_date(date)
            return 0
        except Exception as e:
            logger.error(f"Unexpected error fetching parcel count: {str(e)}")
            return 0
    
    def get_mock_parcel_count_for_date(self, date):
        """Generate mock parcel count for a specific date"""
        # Generate a random but consistent count based on the date
        date_str = date.strftime('%Y-%m-%d')
        hash_object = hashlib.md5(date_str.encode())
        hash_int = int(hash_object.hexdigest(), 16)
        
        # Generate count between 0 and 50 based on date hash
        count = hash_int % 51
        
        return {
            'date': date_str,
            'count': count,
            'message': f'Mock data: {count} parcels for {date_str}'
        }
    
    def get_total_sales_for_date(self, date, request=None, branch=None):
        """Get the total sales for a specific date"""
        try:
            url = f"{self.base_url}/api/Parcels/sales"
            params = {'date': date.isoformat()}
            if branch:
                params['branchName'] = branch
                
            response = requests.get(url, headers=self._get_headers(request), params=params, timeout=10)
            response.raise_for_status()
            return response.json().get('totalSales', 0)
        except requests.exceptions.RequestException as e:
            logger.error(f"Error fetching total sales from API: {str(e)}")
            use_mock = getattr(settings, 'USE_MOCK_DATA', False)
            if use_mock:
                return self.get_mock_total_sales_for_date(date)
            return 0
        except Exception as e:
            logger.error(f"Unexpected error fetching total sales: {str(e)}")
            return 0
    
    def get_mock_total_sales_for_date(self, date):
        """Generate mock sales total for a specific date"""
        # Generate a random but consistent amount based on the date
        date_str = date.strftime('%Y-%m-%d')
        hash_object = hashlib.md5(date_str.encode())
        hash_int = int(hash_object.hexdigest(), 16)
        
        # Generate sales between 0 and 100,000 based on date hash
        sales = (hash_int % 100001)
        
        return {
            'date': date_str,
            'totalSales': sales,
            'currency': 'KES',
            'message': f'Mock data: KES {sales:,} sales for {date_str}'
        }
        
    def dispatch_parcel(self, parcel_id, parcel_data, request=None):
        """Dispatch a parcel"""
        response = requests.post(
            f"{self.base_url}/api/parcels/{parcel_id}/dispatch", 
            headers=self._get_headers(request),
            data=json.dumps(parcel_data)
        )
        response.raise_for_status()
        return response.json() if response.content else None 

    def check_api_connectivity(self, request=None):
        """Check if the API is accessible and log available endpoints"""
        try:
            # Try to access the parcels endpoint which we know works
            response = requests.get(
                f"{self.base_url}/api/parcels", 
                headers=self._get_headers(request), 
                timeout=5
            )
            logger.info(f"API connectivity check - Parcels endpoint status: {response.status_code}")
            
            # Try to access the dispatches endpoint
            response = requests.get(
                f"{self.base_url}/api/dispatches", 
                headers=self._get_headers(request), 
                timeout=5
            )
            logger.info(f"API connectivity check - Dispatches endpoint status: {response.status_code}")
            
            return True
        except Exception as e:
            logger.error(f"API connectivity check failed: {str(e)}")
            return False

    def check_available_endpoints(self):
        """Check available API endpoints via Swagger"""
        try:
            # Try to access Swagger UI
            swagger_url = f"{self.base_url}/swagger"
            logger.info(f"Checking available endpoints at {swagger_url}")
            
            response = requests.get(swagger_url, headers=self.headers, timeout=5)
            logger.info(f"Swagger UI status: {response.status_code}")
            
            # Also try the Swagger JSON endpoint
            swagger_json_url = f"{self.base_url}/swagger/v1/swagger.json"
            logger.info(f"Checking Swagger JSON at {swagger_json_url}")
            
            response = requests.get(swagger_json_url, headers=self.headers, timeout=5)
            if response.status_code == 200:
                swagger_data = response.json()
                logger.info("Available API endpoints:")
                if 'paths' in swagger_data:
                    for path, methods in swagger_data['paths'].items():
                        logger.info(f"Path: {path}")
                        for method, details in methods.items():
                            logger.info(f"  - {method.upper()}: {details.get('summary', 'No summary')}")
            else:
                logger.warning(f"Could not fetch Swagger JSON: {response.status_code}")
            
            return True
        except Exception as e:
            logger.error(f"Error checking available endpoints: {str(e)}")
            return False

    def check_working_endpoints(self):
        """Check which API endpoints are working"""
        endpoints_to_check = [
            '/api/parcels',  # We know this works
            '/api/dispatches',
            '/api/Dispatch',  # Try with capital D
            '/api/dispatch',  # Try with lowercase
            '/api/dispatch/create',
            '/api/Dispatch/create'
        ]
        
        for endpoint in endpoints_to_check:
            try:
                url = f"{self.base_url}{endpoint}"
                logger.info(f"Checking endpoint: {url}")
                response = requests.get(url, headers=self.headers, timeout=5)
                logger.info(f"Endpoint {endpoint} returned status: {response.status_code}")
                if response.content:
                    logger.info(f"Response content: {response.content[:200]}")  # Log first 200 chars
            except Exception as e:
                logger.error(f"Error checking endpoint {endpoint}: {str(e)}")

    def get_parcels_by_ids(self, parcel_ids, request=None):
        """Fetch details for multiple parcels by their IDs."""
        parcels = []
        if not parcel_ids:
            return parcels
            
        logger.info(f"Fetching details for {len(parcel_ids)} parcels by ID.")
        for parcel_id in parcel_ids:
            try:
                parcel_details = self.get_parcel_by_id(parcel_id, request)
                if parcel_details:
                    # Ensure we have a dictionary
                    transformed_parcel = self._transform_parcel(parcel_details)
                    parcels.append(transformed_parcel)
            except Exception as e:
                logger.error(f"Failed to fetch details for parcel ID {parcel_id}: {e}")
                # Decide whether to continue or fail. For now, we continue.
        
        logger.info(f"Successfully fetched details for {len(parcels)} out of {len(parcel_ids)} parcels.")
        return parcels

    def create_dispatch(self, dispatch_data, request):
        parcel_ids = dispatch_data.get('parcel_ids', [])
        parcels_details = self.get_parcels_by_ids(parcel_ids, request)

        if not parcels_details:
            logger.error("No parcel details found for IDs: %s", parcel_ids)
            return None

        # Prepare line items from parcel details with all required fields
        line_items = []
        for parcel in parcels_details:
            line_items.append({
                'Id': str(uuid.uuid4()),
                'ParcelId': parcel['id'],
                'WaybillNumber': parcel['waybillNumber'],
                'Amount': float(parcel.get('totalAmount') or 0),
                'PaymentStatus': parcel.get('paymentMethods'),
                'Description': parcel.get('description'),
                'Quantity': int(parcel.get('quantity') or 0),
                'Rate': float(parcel.get('rate') or 0),
                'TotalRate': float(parcel.get('totalAmount') or 0),
                # Add the missing required fields
                'Sender': parcel.get('sender', ''),
                'Receiver': parcel.get('receiver', ''),
                'Destination': parcel.get('destination', ''),
                'PaymentMethods': parcel.get('paymentMethods', ''),
                'SenderTelephone': parcel.get('senderTelephone', ''),
                'ReceiverTelephone': parcel.get('receiverTelephone', '')
            })
        
        total_amount = sum(item['Amount'] for item in line_items)

        # Match the exact field names the API expects
        payload = {
            'dispatchCode': dispatch_data.get('dispatchCode'),
            'sourceBranch': dispatch_data.get('sourceBranch'),
            'Driver': dispatch_data.get('driver_name'),  # Changed from driverName
            'VehicleNumber': dispatch_data.get('vehicle_registration'),  # Changed from vehicleRegistration
            'Status': 'Pending',  # Add required Status field
            'ParcelIds': parcel_ids,  # Add required ParcelIds field
            'Parcels': line_items,
            'TotalAmount': total_amount,
            'DispatchTime': dispatch_data.get('dispatchTime'),
        }
        
        # Log the dispatch code being sent
        logger.info(f"Dispatch code from dispatch_data: {dispatch_data.get('dispatchCode')}")
        logger.info(f"Dispatch code in payload: {payload.get('dispatchCode')}")
        
        url = f"{self.base_url}/api/dispatches/create"
        logger.info("Sending dispatch creation request to %s with payload: %s", url, payload)
        
        try:
            response = requests.post(url, headers=self.headers, json=payload, timeout=30)
            logger.info("API Response Status: %s", response.status_code)
            logger.info("API Response Headers: %s", dict(response.headers))
            
            if response.content:
                response_content = response.content.decode('utf-8')
                logger.info("API Response Content: %s", response_content)
                
                # Parse and log the response JSON to see what dispatch code the API returned
                try:
                    response_json = response.json()
                    logger.info(f"API Response JSON: {response_json}")
                    if 'dispatchCode' in response_json:
                        logger.info(f"API returned dispatch code: {response_json['dispatchCode']}")
                except Exception as json_error:
                    logger.error(f"Error parsing API response JSON: {json_error}")
            
            response.raise_for_status()
            return response.json()
        except requests.exceptions.RequestException as e:
            logger.error("Error creating dispatch via API: %s", e)
            if hasattr(e, 'response') and e.response:
                logger.error("API response status: %s", e.response.status_code)
                logger.error("API response content: %s", e.response.text)
            return None

    def _transform_parcel(self, parcel_data):
        """
        Transforms a single parcel's data to a consistent format,
        especially handling camelCase vs PascalCase keys.
        """
        # Create a new dictionary with lowercase keys to handle inconsistencies
        # in casing from the API (e.g., 'waybillNumber' vs. 'WaybillNumber').
        lower_cased_data = {k.lower(): v for k, v in parcel_data.items()}

        # Map to a consistent snake_case or desired format.
        # This is an example; adjust keys as needed for your templates.
        return {
            'id': lower_cased_data.get('id'),
            'waybillNumber': lower_cased_data.get('waybillnumber'),
            'sender': lower_cased_data.get('sender'),
            'receiver': lower_cased_data.get('receiver'),
            'destination': lower_cased_data.get('destination'),
            'quantity': lower_cased_data.get('quantity'),
            'description': lower_cased_data.get('description'),
            'totalAmount': lower_cased_data.get('totalamount'),
            'paymentMethods': lower_cased_data.get('paymentmethods'),
            'createdById': lower_cased_data.get('createdbyid'),
            'createdAt': lower_cased_data.get('createdat'),
            'rate': lower_cased_data.get('rate'),
            'status': lower_cased_data.get('status'),
            # Add the required fields for dispatch creation
            'senderTelephone': lower_cased_data.get('sendertelephone'),
            'receiverTelephone': lower_cased_data.get('receivertelephone'),
             # Add any other fields you need, ensuring lowercase key access
        }

    def get_dispatch_by_id(self, dispatch_id, request=None):
        """Get a dispatch by its ID with parcel details"""
        try:
            # Use the note endpoint to get dispatch with parcel details
            url = f"{self.base_url}/api/Dispatches/{dispatch_id}/note"
            logger.info(f"Fetching dispatch {dispatch_id} with parcel details from API")
            
            response = requests.get(url, headers=self._get_headers(request), timeout=15)
            response.raise_for_status()
            
            data = response.json()
            # Handle the $values wrapper if present
            if isinstance(data, dict) and "$values" in data:
                return data["$values"]
            return data
            
        except requests.exceptions.RequestException as e:
            logger.error(f"Error fetching dispatch {dispatch_id}: {str(e)}")
            raise Exception(f"Failed to fetch dispatch: {str(e)}")

    def get_dispatches(self, branch=None, request=None):
        """Get all dispatches, optionally filtered by branch"""
        try:
            if branch:
                url = f"{self.base_url}/api/Dispatches/branch/{branch}"
                logger.info(f"Fetching dispatches for branch {branch} from API")
            else:
                # If no branch specified, get all dispatches
                url = f"{self.base_url}/api/Dispatches"
                logger.info("Fetching all dispatches from API")
            
            response = requests.get(url, headers=self._get_headers(request), timeout=15)
            response.raise_for_status()
            
            data = response.json()
            # Handle the $values wrapper if present
            if isinstance(data, dict) and "$values" in data:
                return data["$values"]
            return data
            
        except requests.exceptions.RequestException as e:
            logger.error(f"Error fetching dispatches: {str(e)}")
            
            # Check if we should use mock data for development/testing
            use_mock = getattr(settings, 'USE_MOCK_DATA', False)
            if use_mock:
                logger.warning("Falling back to mock dispatches since API is unavailable")
                return self.get_mock_dispatches()
                
            raise Exception(f"Failed to fetch dispatches: {str(e)}")

    def get_mock_dispatches(self):
        """Generate mock dispatches for development/testing"""
        destinations = ['Nairobi', 'Mombasa', 'Kisumu', 'Nakuru', 'Eldoret']
        drivers = ['John Doe', 'Jane Smith', 'Mike Johnson', 'Sarah Wilson', 'David Brown']
        vehicles = ['KCA 123A', 'KBZ 456B', 'KAA 789C', 'KDA 012D', 'KBA 345E']
        
        mock_dispatches = []
        
        # Generate 5 mock dispatches
        for i in range(5):
            dispatch_id = str(uuid.uuid4())
            dispatch_time = timezone.now() - timezone.timedelta(days=random.randint(0, 30))
            
            mock_dispatch = {
                'id': dispatch_id,
                'dispatchTime': dispatch_time.isoformat(),
                'sourceBranch': random.choice(destinations),
                'vehicleNumber': random.choice(vehicles),
                'driver': random.choice(drivers),
                'status': random.choice(['pending', 'in_transit', 'delivered']),
                'parcelIds': [str(uuid.uuid4()) for _ in range(random.randint(1, 10))]
            }
            
            mock_dispatches.append(mock_dispatch)
            
        return mock_dispatches

    def get_dispatch_note(self, dispatch_id, request=None):
        """Get dispatch note with parcels from the API"""
        try:
            url = f"{self.base_url}/api/Dispatches/{dispatch_id}/note"
            logger.info(f"Fetching dispatch note from: {url}")
            
            response = requests.get(url, headers=self._get_headers(request), timeout=15)
            logger.info(f"Response status code: {response.status_code}")
            logger.info(f"Response content: {response.content}")
            
            response.raise_for_status()
            
            # Simply return the parsed JSON without modification
            return response.json()
                
        except requests.exceptions.RequestException as e:
            logger.error(f"Error fetching dispatch note: {str(e)}")
            
            # Check if we should use mock data for development/testing
            use_mock = getattr(settings, 'USE_MOCK_DATA', False)
            if use_mock:
                logger.warning(f"Falling back to mock dispatch note for {dispatch_id} since API is unavailable")
                return self.get_mock_dispatch_note(dispatch_id)
                
            raise Exception(f"Failed to fetch dispatch note: {str(e)}")
        except json.JSONDecodeError as e:
            logger.error(f"Error parsing dispatch note response: {str(e)}")
            raise Exception(f"Invalid response from API: {str(e)}")
        except Exception as e:
            logger.error(f"Unexpected error fetching dispatch note: {str(e)}")
            raise Exception(f"An unexpected error occurred: {str(e)}") 
    
    def get_mock_dispatch_note(self, dispatch_id):
        """Generate a mock dispatch note for development/testing"""
        destinations = ['Nairobi', 'Mombasa', 'Kisumu', 'Nakuru', 'Eldoret']
        drivers = ['John Doe', 'Jane Smith', 'Mike Johnson', 'Sarah Wilson', 'David Brown']
        vehicles = ['KCA 123A', 'KBZ 456B', 'KAA 789C', 'KDA 012D', 'KBA 345E']
        
        # Generate mock parcels for this dispatch
        mock_parcels = []
        for i in range(random.randint(2, 8)):
            mock_parcel = {
                'id': str(uuid.uuid4()),
                'waybillNumber': f'WB-{random.randint(10000, 99999)}',
                'qrCode': f'QR-{random.randint(10000, 99999)}',
                'sender': f'Sender {i+1}',
                'senderTelephone': f'07{random.randint(10000000, 99999999)}',
                'receiver': f'Receiver {i+1}',
                'receiverTelephone': f'07{random.randint(10000000, 99999999)}',
                'description': random.choice(['Documents', 'Package', 'Electronics', 'Clothing']),
                'quantity': random.randint(1, 5),
                'amount': random.randint(500, 5000),
                'paymentMethods': random.choice(['Cash', 'M-Pesa', 'Bank Transfer'])
            }
            mock_parcels.append(mock_parcel)
        
        mock_dispatch_note = {
            'dispatchId': str(dispatch_id),
            'dispatchTime': timezone.now().isoformat(),
            'sourceBranch': random.choice(destinations),
            'vehicleNumber': random.choice(vehicles),
            'driver': random.choice(drivers),
            'status': 'in_transit',
            'parcels': {
                '$values': mock_parcels
            }
        }
        
        return mock_dispatch_note

    def update_parcels_status_batch(self, parcel_ids, status, request=None):
        """Update status of multiple parcels at once"""
        try:
            url = f"{self.base_url}/api/parcels/batch/status"
            data = {
                "ParcelIds": parcel_ids,
                "Status": status
            }
            response = requests.put(
                url,
                headers=self._get_headers(request),
                data=json.dumps(data)
            )
            response.raise_for_status()
            return response.json()
        except requests.exceptions.RequestException as e:
            logger.error(f"Error updating parcel statuses: {str(e)}")
            raise Exception(f"Failed to update parcel statuses: {str(e)}")