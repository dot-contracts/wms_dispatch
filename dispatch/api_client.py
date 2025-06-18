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
                'status': random.randint(0, 3)
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
            'status': random.randint(0, 3)
        }
        
        return mock_parcel
    
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

    def create_dispatch(self, dispatch_data, request=None):
        """Create a new dispatch through the API"""
        try:
            url = f"{self.base_url}/api/dispatches/create"
            logger.info(f"Creating dispatch via API at {url}")
            
            # Clean up parcel data with minimal required fields
            cleaned_parcels = []
            for parcel in dispatch_data.get('Parcels', []):
                cleaned_parcel = {
                    'Id': parcel.get('id'),
                    'WaybillNumber': parcel.get('waybillNumber'),
                    'Status': parcel.get('status', 0),
                    'Destination': parcel.get('destination') or "Unknown",
                    'Sender': parcel.get('sender') or "Unknown",
                    'Receiver': parcel.get('receiver') or "Unknown",
                    'SenderTelephone': parcel.get('senderTelephone') or "N/A",
                    'ReceiverTelephone': parcel.get('receiverTelephone') or "N/A",
                    'Quantity': int(parcel.get('quantity', 1)),
                    'Description': parcel.get('description') or "",
                    'Amount': float(parcel.get('amount', 0)),
                    'PaymentMethods': parcel.get('paymentMethods') or "COD",
                    'TotalAmount': float(parcel.get('amount', 0)),  # Match Amount as fallback
                    'TotalRate': float(parcel.get('rate', 0))  # Use Rate as fallback
                }
                cleaned_parcels.append(cleaned_parcel)
            
            # Format dispatch time to ISO format without microseconds
            dispatch_time = datetime.fromisoformat(dispatch_data.get('dispatchTime').replace('Z', '+00:00'))
            formatted_time = dispatch_time.strftime('%Y-%m-%dT%H:%M:%S.000Z')
            
            # Construct the dispatch payload
            dispatch_payload = {
                'SourceBranch': dispatch_data.get('sourceBranch'),
                'VehicleNumber': dispatch_data.get('vehicleNumber'),
                'Driver': dispatch_data.get('driver'),
                'ParcelIds': dispatch_data.get('ParcelIds'),
                'Status': 'in_transit',
                'DispatchTime': formatted_time,
                'Parcels': cleaned_parcels
            }
            
            logger.info(f"Request URL: {url}")
            logger.info(f"Request Headers: {self._get_headers(request)}")
            logger.info(f"Request Data: {json.dumps(dispatch_payload, indent=2)}")
            
            headers = {
                **self._get_headers(request),
                'X-Requested-With': 'XMLHttpRequest',
                'Origin': settings.API_BASE_URL,
                'Referer': settings.API_BASE_URL
            }
            
            response = requests.post(
                url, 
                headers=headers, 
                json=dispatch_payload
            )
            response.raise_for_status()
            
            return response.json()
        except requests.exceptions.RequestException as e:
            logger.error(f"Error in dispatch creation process: {str(e)}")
            if hasattr(e, 'response') and e.response is not None:
                logger.error(f"Error response status: {e.response.status_code}")
                logger.error(f"Error response content: {e.response.content}")
                logger.error(f"Error response headers: {e.response.headers}")
            raise Exception(f"Failed to create dispatch: {str(e)}")

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