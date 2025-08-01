from django.utils.deprecation import MiddlewareMixin
from .auth_backend import ApiUser
import logging

logger = logging.getLogger(__name__)

class AnonymousUser:
    """Simple anonymous user class that doesn't depend on Django's auth"""
    def __init__(self):
        self.is_authenticated = False
        self.is_active = False
        self.is_anonymous = True
        self.username = ''
        
    def has_perm(self, perm, obj=None):
        return False
    
    def has_module_perms(self, app_label):
        return False

class ApiAuthenticationMiddleware(MiddlewareMixin):
    """Custom middleware to handle API-based authentication"""
    
    def process_request(self, request):
        # Check if user data is stored in session
        user_data = request.session.get('user_data')
        api_token = request.session.get('api_token')
        
        if user_data and api_token:
            # Create ApiUser from session data
            request.user = ApiUser(user_data)
            logger.debug(f"User {request.user.username} authenticated from session")
            logger.debug(f"Session user data: {user_data}")
            logger.debug(f"User roleId: {getattr(request.user, 'roleId', 'No roleId')}")
        else:
            # User is not authenticated
            request.user = AnonymousUser()
            
        return None

def login_user(request, user, api_token):
    """Custom login function to store user data in session"""
    # Extract roleId from role.id to ensure it's not None
    role_id = None
    if hasattr(user, 'role') and user.role and isinstance(user.role, dict) and 'id' in user.role:
        role_id = user.role['id']
    elif hasattr(user, 'roleId') and user.roleId is not None:
        role_id = user.roleId
    
    # Clean role data to remove problematic fields like $id
    clean_role = {}
    if hasattr(user, 'role') and user.role and isinstance(user.role, dict):
        for key, value in user.role.items():
            if not key.startswith('$'):  # Skip fields starting with $
                clean_role[key] = value
    
    session_data = {
        'id': user.id,
        'username': user.username,
        'email': user.email,
        'firstName': user.first_name,
        'lastName': user.last_name,
        'role': clean_role,  # Use cleaned role data
        'roleId': role_id,  # Use extracted roleId
        'branch': user.branch
    }
    
    request.session['user_data'] = session_data
    request.session['api_token'] = api_token
    request.user = user
    logger.info(f"User {user.username} logged in successfully with roleId: {role_id}")

def logout_user(request):
    """Custom logout function to clear session data"""
    username = getattr(request.user, 'username', 'Unknown')
    request.session.pop('user_data', None)
    request.session.pop('api_token', None)
    request.user = AnonymousUser()
    logger.info(f"User {username} logged out successfully")

def is_authenticated(user):
    """Check if user is authenticated"""
    return hasattr(user, 'is_authenticated') and user.is_authenticated

def login_required_api(view_func):
    """Custom login required decorator for API-based authentication"""
    from functools import wraps
    from django.shortcuts import redirect
    from django.contrib import messages
    
    @wraps(view_func)
    def wrapper(request, *args, **kwargs):
        if not is_authenticated(request.user):
            messages.warning(request, 'Please log in to access this page.')
            return redirect('login')
        return view_func(request, *args, **kwargs)
    return wrapper 