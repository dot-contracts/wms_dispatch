import os
import django

# Set Django settings module
os.environ.setdefault('DJANGO_SETTINGS_MODULE', 'ems.settings')
django.setup()

from django.contrib.auth.models import User
from employee.models import Employee, Role, Branch

def create_admin_employee():
    try:
        # Get admin user
        admin_user = User.objects.get(username='ficma_admin')
        
        # Check if employee record already exists
        if Employee.objects.filter(user=admin_user).exists():
            print(f"Employee record already exists for user {admin_user.username}")
            return
            
        # Get admin role
        admin_role = Role.objects.get(name='admin')
        
        # Get all branches
        branches = Branch.objects.all()
        
        # Create employee record
        employee = Employee.objects.create(
            user=admin_user,
            employee_id='FHL-001',
            phone_number='0716389767',
            id_number='26946087',
            is_active=True
        )
        
        # Add roles and branches
        employee.roles.add(admin_role)
        for branch in branches:
            employee.branches.add(branch)
            
        print(f"Successfully created employee record for {admin_user.username}")
        print(f"Employee ID: {employee.employee_id}")
        print(f"Roles: {', '.join([role.name for role in employee.roles.all()])}")
        print(f"Branches: {', '.join([branch.name for branch in employee.branches.all()])}")
        
    except User.DoesNotExist:
        print("Admin user 'ficma_admin' does not exist. Please create it first.")
    except Role.DoesNotExist:
        print("Admin role does not exist. Please load initial data first.")
    except Exception as e:
        print(f"Error: {e}")

if __name__ == "__main__":
    create_admin_employee() 