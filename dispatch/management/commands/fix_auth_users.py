from django.core.management.base import BaseCommand
from django.contrib.auth.models import User
from dispatch.models import UserProfile, Branch
import logging

# Set up logger
logger = logging.getLogger(__name__)

class Command(BaseCommand):
    help = 'Fix authentication issues for specific users'

    def handle(self, *args, **options):
        # Set up logger
        logger = logging.getLogger(__name__)
        
        # Create or update problematic users
        problem_users = [
            {
                'username': 'ficma_admin',
                'password': 'admin123',  # Example password, change in production!
                'email': 'ficma_admin@example.com',
                'first_name': 'FICMA',
                'last_name': 'Admin',
                'is_superuser': True,
                'is_staff': True,
                'branch': None,  # Admin has no branch restrictions
                'is_branch_manager': False,
                'roles': ['Admin']
            },
            {
                'username': 'dotcontracts',
                'password': 'manager123',  # Example password, change in production!
                'email': 'dotcontracts@example.com',
                'first_name': 'Dot',
                'last_name': 'Contracts',
                'is_superuser': False,
                'is_staff': True,
                'branch': 'Nakuru',
                'is_branch_manager': True,
                'roles': ['Manager']
            },
        ]
        
        for user_data in problem_users:
            # Get or create user
            try:
                user = User.objects.get(username=user_data['username'])
                self.stdout.write(self.style.WARNING(f'User already exists: {user_data["username"]}'))
                
                # Force update the password to fix any potential issues
                user.set_password(user_data['password'])
                user.save()
                self.stdout.write(self.style.SUCCESS(f'Reset password for: {user_data["username"]}'))
                
            except User.DoesNotExist:
                user = User.objects.create_user(
                    username=user_data['username'],
                    email=user_data['email'],
                    password=user_data['password'],
                    first_name=user_data['first_name'],
                    last_name=user_data['last_name'],
                    is_superuser=user_data['is_superuser'],
                    is_staff=user_data['is_staff']
                )
                self.stdout.write(self.style.SUCCESS(f'Created user: {user_data["username"]}'))
            
            # Get or create user profile
            try:
                profile = UserProfile.objects.get(user=user)
                self.stdout.write(self.style.WARNING(f'Profile already exists for: {user_data["username"]}'))
            except UserProfile.DoesNotExist:
                branch = None
                if user_data['branch']:
                    try:
                        branch = Branch.objects.get(name=user_data['branch'])
                    except Branch.DoesNotExist:
                        # Create the branch if it doesn't exist
                        branch = Branch.objects.create(name=user_data['branch'])
                        self.stdout.write(self.style.SUCCESS(f'Created branch: {user_data["branch"]}'))
                
                profile = UserProfile.objects.create(
                    user=user,
                    branch=branch,
                    is_branch_manager=user_data['is_branch_manager']
                )
                self.stdout.write(self.style.SUCCESS(f'Created profile for: {user_data["username"]}'))
            
            # Update existing profile if needed
            if user_data['branch'] and (profile.branch is None or (profile.branch and profile.branch.name != user_data['branch'])):
                try:
                    branch = Branch.objects.get(name=user_data['branch'])
                    profile.branch = branch
                    profile.save()
                    self.stdout.write(self.style.SUCCESS(f'Updated branch for user: {user_data["username"]}'))
                except Branch.DoesNotExist:
                    branch = Branch.objects.create(name=user_data['branch'])
                    profile.branch = branch
                    profile.save()
                    self.stdout.write(self.style.SUCCESS(f'Created and assigned branch for user: {user_data["username"]}'))
            
            if profile.is_branch_manager != user_data['is_branch_manager']:
                profile.is_branch_manager = user_data['is_branch_manager']
                profile.save()
                self.stdout.write(self.style.SUCCESS(f'Updated branch manager status for: {user_data["username"]}'))

        self.stdout.write(self.style.SUCCESS('Authentication fix complete!'))
        self.stdout.write(self.style.SUCCESS('Run python manage.py runserver to restart the application'))