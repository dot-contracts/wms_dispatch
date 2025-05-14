import requests
import json
from django.conf import settings
from datetime import datetime
from decimal import Decimal
import logging
import uuid
import random
from django.utils import timezone

# Set up logger
logger = logging.getLogger(__name__)

class WmsApiClient:
    def __init__(self):
        self.base_url = settings.WMS_API_URL
        self.headers = {
            'Content-Type': 'application/json',
            'Accept': 'application/json',
        }
    
    def get_parcels(self):
        """Get all parcels from the API"""
        try:
            logger.info(f"Attempting to get parcels from {self.base_url}/api/parcels")
            response = requests.get(f"{self.base_url}/api/parcels", headers=self.headers, timeout=15)
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
    
    def get_parcel_by_id(self, parcel_id):
        """Get a parcel by its ID"""
        response = requests.get(f"{self.base_url}/api/parcels/{parcel_id}", headers=self.headers)
        response.raise_for_status()
        return response.json()
    
    def get_parcel_by_waybill(self, waybill_number):
        """Get a parcel by its waybill number"""
        response = requests.get(f"{self.base_url}/api/parcels/waybill/{waybill_number}", headers=self.headers)
        response.raise_for_status()
        return response.json()
    
    def get_pending_parcels(self):
        """Get all pending parcels"""
        response = requests.get(f"{self.base_url}/api/parcels/pending", headers=self.headers)
        response.raise_for_status()
        return response.json()
    
    def get_parcel_count_for_date(self, date):
        """Get count of parcels for a specific date"""
        date_str = date.strftime('%Y-%m-%d')
        response = requests.get(f"{self.base_url}/api/parcels/count/{date_str}", headers=self.headers)
        response.raise_for_status()
        return response.json()
    
    def get_total_sales_for_date(self, date):
        """Get total sales for a specific date"""
        date_str = date.strftime('%Y-%m-%d')
        response = requests.get(f"{self.base_url}/api/parcels/sales/{date_str}", headers=self.headers)
        response.raise_for_status()
        return response.json()
        
    def dispatch_parcel(self, parcel_id, parcel_data):
        """Dispatch a parcel"""
        response = requests.post(
            f"{self.base_url}/api/parcels/{parcel_id}/dispatch", 
            headers=self.headers,
            data=json.dumps(parcel_data)
        )
        response.raise_for_status()
        return response.json() if response.content else None 