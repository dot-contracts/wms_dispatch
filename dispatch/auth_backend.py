import requests
import logging
from django.conf import settings

logger = logging.getLogger(__name__)

class ApiUser:
    """Custom user class that doesn't require database"""
    def __init__(self, user_data):
        self.id = user_data.get('id')
        self.username = user_data.get('username')
        self.email = user_data.get('email')
        self.first_name = user_data.get('firstName', '')
        self.last_name = user_data.get('lastName', '')
        self.role = user_data.get('role', {})
        self.roleId = user_data.get('roleId')  # Store roleId for fallback checks
        self.branch = user_data.get('branch', {})
        self.is_authenticated = True
        self.is_active = True
        self.is_anonymous = False
        
    def get_full_name(self):
        return f"{self.first_name} {self.last_name}".strip()
    
    def get_short_name(self):
        return self.first_name or self.username
    
    def has_perm(self, perm, obj=None):
        # For now, all authenticated users have all permissions
        # You can implement role-based permissions here
        return True
    
    def has_module_perms(self, app_label):
        return True
    
    def is_manager(self):
        return self.role.get('name', '').lower() == 'manager'
    
    def is_admin(self):
        role_name = self.role.get('name', '').lower()
        role_id = self.role.get('id') or getattr(self, 'roleId', None)
        logger.error(f"ADMIN CHECK for user {self.username}: role={self.role}, role_name='{role_name}', role_id={role_id}")
        
        # Primary check: role name is 'admin'
        if role_name == 'admin':
            logger.error(f"User {self.username} is admin by role name")
            return True
            
        # Fallback check: roleId = 1 (typically admin in many systems)
        if role_id == 1:
            logger.error(f"User {self.username} is admin by roleId=1")
            return True
            
        logger.error(f"User {self.username} is NOT admin")
        return False
    
    @property
    def admin_status(self):
        """Property version of is_admin for easier template access"""
        return self.is_admin()

    def is_clerk(self):
        return self.role.get('name', '').lower() == 'clerk'

class ApiAuthenticationBackend:
    """Custom authentication backend that validates against the API"""
    
    def authenticate(self, request, username=None, password=None, **kwargs):
        if not username or not password:
            return None
            
        try:
            # Authenticate against the API
            response = requests.post(
                f"{settings.API_BASE_URL}/api/Auth/login",
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
                user_id = token_data.get('userId')
                    
                if api_token and user_id:
                    # Store the token in the session for later use
                    if request:
                        request.session['api_token'] = api_token
                    
                    # Get user details from the API
                    user_response = requests.get(
                        f"{settings.API_BASE_URL}/api/Users/{user_id}",
                        headers={
                            'Authorization': f'Bearer {api_token}',
                            'Content-Type': 'application/json'
                        },
                        timeout=10
                    )
                    
                    if user_response.status_code == 200:
                        user_data = user_response.json()
                        # Debug logging to check role data
                        logger.info(f"User data for {username}: {user_data}")
                        logger.info(f"Role data: {user_data.get('role', 'No role field')}")
                        
                        # Extract roleId from role.id if role exists
                        role_data = user_data.get('role', {})
                        if role_data and 'id' in role_data:
                            user_data['roleId'] = role_data['id']
                            logger.info(f"Extracted roleId: {role_data['id']}")
                        else:
                            logger.info(f"No role.id found in user data")
                        
                        return ApiUser(user_data)
                    else:
                        logger.warning(f"Failed to get user details for {username}")
                        # Fallback to creating a basic user if details fetch fails
                        return ApiUser({
                            'id': user_id,
                            'username': username,
                            'email': '',
                            'firstName': username,
                            'lastName': '',
                            'role': {'name': 'User'}
                        })
            else:
                logger.warning(f"Authentication failed for user {username}: {response.status_code}")
                
        except Exception as e:
            logger.error(f"Error during API authentication for {username}: {str(e)}")
            
        return None
    
    def get_user(self, user_id):
        # This method is required by Django's auth framework.
        # In our case, we don't have direct access to user data without a request context
        # that holds the API token. The user object is constructed during authentication
        # and stored in the session by middleware.
        # Returning None is acceptable here as long as session management is handled correctly.
        return None 