from django.contrib.auth.backends import BaseBackend
from django.contrib.auth.models import User
from .auth_client import AuthApiClient
from .models import UserProfile, Branch
import logging
from django.contrib.auth.hashers import check_password

# Set up logger
logger = logging.getLogger(__name__)

class EmsAuthBackend(BaseBackend):
    """
    Custom authentication backend that validates credentials against the EMS API
    """
    
    def authenticate(self, request, username=None, password=None, **kwargs):
        """
        Authenticate a user against the EMS API
        If authentication is successful, create or update a local User object
        """
        if not username or not password:
            return None
            
        # Authenticate against the EMS API
        auth_client = AuthApiClient()
        user_data = auth_client.authenticate_user(username, password)
        
        if user_data is None:
            logger.warning(f"Authentication failed for user {username}")
            return None
        
        # For testing/development, compare password directly with the local database
        # In production, you should never do this - this is just for testing
        try:
            # Try to find a user with this username
            user = User.objects.get(username=username)
            
            # For development only - accepting the local password match
            # Remove this code in production
            if hasattr(user, 'password') and user.has_usable_password():
                if check_password(password, user.password):
                    logger.info(f"User {username} authenticated via local password")
                    
                    # Store roles and branch in session if they're in user_data
                    if request and hasattr(request, 'session'):
                        if isinstance(user_data, dict):
                            # Store roles
                            request.session['user_roles'] = user_data.get('roles', ['Employee'])
                            # Store branch
                            request.session['user_branch'] = user_data.get('branch')
                        else:
                            # Default values if none found
                            request.session['user_roles'] = ['Employee']
                            request.session['user_branch'] = None
                            
                    return user
        except User.DoesNotExist:
            pass
        
        # The structure of user_data might vary based on which endpoint was used
        # Extract the necessary fields, with fallbacks for different API responses
        
        # Try to extract email, first name, last name from user_data
        email = None
        first_name = None
        last_name = None
        branch_name = None
        is_manager = False
        
        if isinstance(user_data, dict):
            # Try different field names that might be used
            email = user_data.get('email') or user_data.get('Email') or f"{username}@example.com"
            first_name = user_data.get('firstName') or user_data.get('first_name') or user_data.get('FirstName') or ''
            last_name = user_data.get('lastName') or user_data.get('last_name') or user_data.get('LastName') or ''
            branch_name = user_data.get('branch')
            is_manager = 'Manager' in user_data.get('roles', [])
        
        try:
            # Try to get existing user from our database
            user = User.objects.get(username=username)
            
            # Update user information if needed
            if email and user.email != email:
                user.email = email
                user.save()
                
            if first_name and user.first_name != first_name:
                user.first_name = first_name
                user.save()
                
            if last_name and user.last_name != last_name:
                user.last_name = last_name
                user.save()
                
        except User.DoesNotExist:
            # Create a new user in our database
            user = User(
                username=username,
                email=email or f"{username}@example.com",
                first_name=first_name or '',
                last_name=last_name or ''
            )
            user.is_staff = False
            user.is_superuser = False
            
            # Set a password for local authentication during development
            # In production, you would keep using the API for auth
            user.set_password(password)
            user.save()
        
        # Create or update user profile with branch information
        try:
            profile = UserProfile.objects.get(user=user)
            
            # Update branch information if needed
            if branch_name:
                branch, created = Branch.objects.get_or_create(name=branch_name)
                profile.branch = branch
                profile.is_branch_manager = is_manager
                profile.save()
                
        except UserProfile.DoesNotExist:
            # Create profile with branch info if available
            branch = None
            if branch_name:
                branch, created = Branch.objects.get_or_create(name=branch_name)
                
            UserProfile.objects.create(
                user=user,
                branch=branch,
                is_branch_manager=is_manager
            )
            
        # Store user roles and branch in the session
        if request and hasattr(request, 'session'):
            if isinstance(user_data, dict):
                request.session['user_roles'] = user_data.get('roles', ['Employee'])
                request.session['user_branch'] = branch_name
            else:
                # Default role if none found
                request.session['user_roles'] = ['Employee']
                request.session['user_branch'] = None
            
        return user
    
    def get_user(self, user_id):
        try:
            return User.objects.get(pk=user_id)
        except User.DoesNotExist:
            return None
            
    def has_perm(self, user_obj, perm, obj=None):
        """
        Check if user has the given permission
        This is simplified - for a real app, implement proper permission checks
        """
        return user_obj.is_authenticated

def user_has_role(user, required_roles):
    """
    Helper function to check if a user has at least one of the required roles
    """
    if not user.is_authenticated:
        return False
        
    # Get roles from session
    roles = user.session.get('user_roles', [])
    
    for role in required_roles:
        if role in roles:
            return True
            
    return False

def is_admin(user):
    """Check if the user is an admin"""
    if not user.is_authenticated:
        return False
    
    roles = user.session.get('user_roles', [])
    return 'Admin' in roles

def get_user_branch(user):
    """Get the user's branch from session or profile"""
    if not user.is_authenticated:
        return None
    
    # First try session
    branch = user.session.get('user_branch')
    if branch:
        return branch
    
    # Then try profile
    try:
        profile = UserProfile.objects.get(user=user)
        return profile.branch.name if profile.branch else None
    except UserProfile.DoesNotExist:
        return None 