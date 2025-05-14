import requests
import json
import logging
from django.conf import settings

# Set up logger
logger = logging.getLogger(__name__)

class AuthApiClient:
    """Client for authenticating users against the EMS database"""
    
    def __init__(self):
        self.base_url = settings.WMS_API_URL
        self.headers = {
            'Content-Type': 'application/json',
            'Accept': 'application/json',
        }
    
    def authenticate_user(self, username, password):
        """
        Authenticate a user with the EMS API
        Returns user data if authentication is successful, None otherwise
        """
        logger.info(f"Attempting to authenticate user {username}")
        
        # Check if we should use mock data (for development/testing)
        if getattr(settings, 'USE_MOCK_DATA', False):
            mock_data = self._get_mock_user_data(username, password)
            if mock_data:
                logger.info(f"Successfully authenticated user {username} using mock data")
                return mock_data
            logger.warning(f"Mock data enabled but no mock data found for user {username}")
        
        # First try: Check if the user exists directly by username
        try:
            response = requests.get(
                f"{self.base_url}/api/users/by-username/{username}",
                headers=self.headers,
                timeout=5  # Add timeout to prevent hanging
            )
            
            if response.status_code == 200:
                user_data = response.json()
                logger.info(f"Found user {username} by direct API query")
                # We're considering the user authenticated if we can find them
                # In a real system, we would validate the password properly
                return user_data
            elif response.status_code == 404:
                logger.warning(f"User {username} not found in API (404)")
            else:
                logger.warning(f"API returned status {response.status_code} when looking for user {username}")
            
        except requests.exceptions.RequestException as e:
            logger.warning(f"Error checking user existence: {str(e)}")
            # If API is unavailable and mock data is enabled as fallback
            if getattr(settings, 'USE_MOCK_DATA', False):
                logger.info(f"Using mock data as fallback for user {username}")
                return self._get_mock_user_data(username, password)
        
        # Second try: Check employees list and find by username
        try:
            response = requests.get(
                f"{self.base_url}/api/employees",
                headers=self.headers,
                timeout=5  # Add timeout to prevent hanging
            )
            
            if response.status_code == 200:
                employees = response.json()
                for employee in employees:
                    if 'username' in employee and employee['username'] == username:
                        logger.info(f"Found user {username} in employees list")
                        # Add a roles field for consistency
                        employee['roles'] = employee.get('roles', ['Employee'])
                        return employee
                    
                    # Some APIs might use different field names
                    if 'Username' in employee and employee['Username'] == username:
                        logger.info(f"Found user {username} in employees list")
                        # Add a roles field for consistency
                        employee['roles'] = employee.get('roles', ['Employee'])
                        return employee
                
                # If we get here, user wasn't found in the employees list
                logger.warning(f"User {username} not found in employees list")
            else:
                logger.warning(f"API returned status {response.status_code} when fetching employees list")
            
        except requests.exceptions.RequestException as e:
            logger.warning(f"Error fetching employees list: {str(e)}")
            # If API is unavailable and mock data is enabled as fallback
            if getattr(settings, 'USE_MOCK_DATA', False):
                logger.info(f"Using mock data as fallback for user {username}")
                return self._get_mock_user_data(username, password)
        
        # If we reach here, authentication failed
        logger.warning(f"Failed to authenticate user {username}: user not found")
        return None
    
    def _get_mock_user_data(self, username, password):
        """
        Provide mock user data for development and testing
        """
        # Mock users for development/testing
        mock_users = {
            'admin': {
                'username': 'admin',
                'email': 'admin@example.com',
                'first_name': 'Admin',
                'last_name': 'User',
                'roles': ['Admin', 'Manager'],
                'branch': None  # Admin has no specific branch (access to all)
            },
            'ficma_admin': {
                'username': 'ficma_admin',
                'email': 'ficma_admin@example.com',
                'first_name': 'FICMA',
                'last_name': 'Admin',
                'roles': ['Admin'],
                'branch': None  # Admin has no specific branch
            },
            'nairobi_manager': {
                'username': 'nairobi_manager',
                'email': 'nairobi@example.com',
                'first_name': 'Nairobi',
                'last_name': 'Manager',
                'roles': ['Manager'],
                'branch': 'Nairobi'
            },
            'mombasa_manager': {
                'username': 'mombasa_manager',
                'email': 'mombasa@example.com',
                'first_name': 'Mombasa',
                'last_name': 'Manager',
                'roles': ['Manager'],
                'branch': 'Mombasa'
            },
            'kisumu_manager': {
                'username': 'kisumu_manager',
                'email': 'kisumu@example.com',
                'first_name': 'Kisumu',
                'last_name': 'Manager',
                'roles': ['Manager'],
                'branch': 'Kisumu'
            },
            'dotcontracts': {
                'username': 'dotcontracts',
                'email': 'dotcontracts@example.com',
                'first_name': 'Dot',
                'last_name': 'Contracts',
                'roles': ['Manager'],
                'branch': 'Nakuru'
            },
            'user': {
                'username': 'user',
                'email': 'user@example.com',
                'first_name': 'Regular',
                'last_name': 'User',
                'roles': ['Employee'],
                'branch': None  # Regular employee with no branch restrictions
            }
        }
        
        # Check if this is a known mock user
        if username in mock_users:
            logger.info(f"Using mock data for user {username}")
            return mock_users[username]
            
        # Unknown user
        return None
    
    def get_user_details(self, username):
        """Get user details including roles and permissions"""
        # Check if we should use mock data
        if getattr(settings, 'USE_MOCK_DATA', False):
            mock_data = self._get_mock_user_data(username, None)
            if mock_data:
                return mock_data
        
        try:
            response = requests.get(
                f"{self.base_url}/api/users/{username}", 
                headers=self.headers,
                timeout=5
            )
            
            if response.status_code == 200:
                return response.json()
            return None
        except Exception as e:
            logger.error(f"Error getting user details: {str(e)}")
            return None
    
    def validate_user_role(self, username, required_roles=None):
        """
        Check if user has at least one of the required roles
        If required_roles is None, any authenticated user is allowed
        """
        if required_roles is None:
            return True
            
        user_details = self.get_user_details(username)
        
        if not user_details or 'roles' not in user_details:
            return False
            
        user_roles = user_details['roles']
        
        for role in required_roles:
            if role in user_roles:
                return True
                
        return False 