from django.core.management.base import BaseCommand
from django.contrib.auth.models import User
from dispatch.models import Branch, UserProfile, Parcel
import logging
import random

class Command(BaseCommand):
    help = 'Set up test data for branches and user profiles'

    def handle(self, *args, **options):
        # Set up logger
        logger = logging.getLogger(__name__)
        
        # Create branches
        branches = ['Nairobi', 'Mombasa', 'Kisumu', 'Nakuru', 'Eldoret']
        created_branches = []
        
        for branch_name in branches:
            branch, created = Branch.objects.get_or_create(name=branch_name)
            created_branches.append(branch)
            if created:
                self.stdout.write(self.style.SUCCESS(f'Created branch: {branch_name}'))
            else:
                self.stdout.write(self.style.WARNING(f'Branch already exists: {branch_name}'))
        
        # Create or update user profiles
        test_users = [
            {
                'username': 'admin',
                'password': 'admin123',
                'email': 'admin@example.com',
                'first_name': 'Admin',
                'last_name': 'User',
                'is_superuser': True,
                'is_staff': True,
                'branch': None,  # Admin has no branch restrictions
                'is_branch_manager': False
            },
            {
                'username': 'nairobi_manager',
                'password': 'manager123',
                'email': 'nairobi@example.com',
                'first_name': 'Nairobi',
                'last_name': 'Manager',
                'is_superuser': False,
                'is_staff': True,
                'branch': 'Nairobi',
                'is_branch_manager': True
            },
            {
                'username': 'mombasa_manager',
                'password': 'manager123',
                'email': 'mombasa@example.com',
                'first_name': 'Mombasa',
                'last_name': 'Manager',
                'is_superuser': False,
                'is_staff': True,
                'branch': 'Mombasa',
                'is_branch_manager': True
            },
            {
                'username': 'kisumu_manager',
                'password': 'manager123',
                'email': 'kisumu@example.com',
                'first_name': 'Kisumu',
                'last_name': 'Manager',
                'is_superuser': False,
                'is_staff': True,
                'branch': 'Kisumu',
                'is_branch_manager': True
            },
            {
                'username': 'user',
                'password': 'user123',
                'email': 'user@example.com',
                'first_name': 'Regular',
                'last_name': 'User',
                'is_superuser': False,
                'is_staff': False,
                'branch': None,  # Regular user, no branch restrictions
                'is_branch_manager': False
            }
        ]
        
        for user_data in test_users:
            # Get or create user
            try:
                user = User.objects.get(username=user_data['username'])
                self.stdout.write(self.style.WARNING(f'User already exists: {user_data["username"]}'))
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
                        self.stdout.write(self.style.ERROR(f'Branch not found: {user_data["branch"]}'))
                        continue
                
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
                    self.stdout.write(self.style.ERROR(f'Branch not found: {user_data["branch"]}'))
            
            if profile.is_branch_manager != user_data['is_branch_manager']:
                profile.is_branch_manager = user_data['is_branch_manager']
                profile.save()
                self.stdout.write(self.style.SUCCESS(f'Updated branch manager status for: {user_data["username"]}'))
        
        # Create sample parcels if none exist
        if Parcel.objects.count() == 0:
            self.stdout.write(self.style.SUCCESS('Creating sample parcels...'))
            
            for i in range(50):  # Create 50 sample parcels
                destination = random.choice(branches)
                status = random.randint(0, 3)  # Random status (0-3)
                
                waybill = f'WB{random.randint(1000, 9999)}'
                sender = f'Sender {i+1}'
                receiver = f'Receiver {i+1}'
                amount = random.randint(100, 5000)
                
                Parcel.objects.create(
                    waybill_number=waybill,
                    sender=sender,
                    sender_telephone='0700000000',
                    receiver=receiver,
                    receiver_telephone='0711111111',
                    destination=destination,
                    description=f'Test parcel {i+1}',
                    quantity=1,
                    amount=amount,
                    rate=0,
                    payment_methods='Cash',
                    total_amount=amount,
                    total_rate=0,
                    status=status
                )
            
            self.stdout.write(self.style.SUCCESS(f'Created {50} sample parcels'))
        else:
            self.stdout.write(self.style.WARNING('Parcels already exist, skipping sample parcel creation'))
        
        self.stdout.write(self.style.SUCCESS('Test data setup complete!'))