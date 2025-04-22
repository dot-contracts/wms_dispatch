from django.shortcuts import render, redirect, get_object_or_404
from django.contrib import messages
from django.contrib.auth import authenticate, login, logout
from django.contrib.auth.decorators import login_required, user_passes_test
from django.contrib.auth.models import User
from django.db import transaction
from django.utils import timezone
from datetime import datetime
from .models import Employee, Role, Branch, LoginActivity
from .forms import (
    UserRegistrationForm, EmployeeForm, UserLoginForm,
    UserUpdateForm, EmployeeUpdateForm, PasswordResetRequestForm
)

def is_admin(user):
    """Check if user has admin role"""
    if not user.is_authenticated:
        return False
    try:
        return user.employee.roles.filter(name='admin').exists()
    except Employee.DoesNotExist:
        return False

def home(request):
    """Home page view"""
    return render(request, 'employee/home.html')

def login_view(request):
    """Login view"""
    if request.method == 'POST':
        form = UserLoginForm(request.POST)
        if form.is_valid():
            username = form.cleaned_data.get('username')
            password = form.cleaned_data.get('password')
            user = authenticate(username=username, password=password)
            if user is not None:
                login(request, user)
                messages.success(request, f'Welcome back, {user.first_name}!')
                return redirect('employee_dashboard')
            else:
                messages.error(request, 'Invalid username or password.')
    else:
        form = UserLoginForm()
    return render(request, 'employee/login.html', {'form': form})

def logout_view(request):
    """Logout view"""
    logout(request)
    messages.info(request, 'You have been logged out.')
    return redirect('login')

@login_required
def dashboard(request):
    """Dashboard view for employees"""
    employee = get_object_or_404(Employee, user=request.user)
    context = {
        'employee': employee,
    }
    return render(request, 'employee/dashboard.html', context)

@login_required
@user_passes_test(is_admin)
def employee_list(request):
    """View to list all employees"""
    employees = Employee.objects.all().select_related('user').prefetch_related('roles', 'branches')
    return render(request, 'employee/employee_list.html', {'employees': employees})

@login_required
@user_passes_test(is_admin)
@transaction.atomic
def register_employee(request):
    """View to register a new employee"""
    if request.method == 'POST':
        user_form = UserRegistrationForm(request.POST)
        employee_form = EmployeeForm(request.POST)
        
        if user_form.is_valid() and employee_form.is_valid():
            user = user_form.save()
            employee = employee_form.save(commit=False)
            
            # Auto-generate employee ID if not provided or if provided but empty
            if not employee.employee_id:
                # Get the last employee ID
                last_employee = Employee.objects.order_by('-id').first()
                if last_employee and last_employee.employee_id and last_employee.employee_id.startswith('FHL_'):
                    try:
                        # Extract the sequential number and increment
                        last_number = int(last_employee.employee_id.split('_')[1])
                        next_number = last_number + 1
                    except (IndexError, ValueError):
                        # If extraction fails, start from 1
                        next_number = 1
                else:
                    # No existing employee or invalid format, start from 1
                    next_number = 1
                
                # Format: FHL_001, FHL_002, etc.
                employee.employee_id = f"FHL_{next_number:03d}"
            
            employee.user = user
            employee.save()
            employee_form.save_m2m()  # Save many-to-many relationships
            
            messages.success(request, f'Employee {employee.full_name} has been registered successfully.')
            return redirect('employee_list')
    else:
        user_form = UserRegistrationForm()
        employee_form = EmployeeForm()
    
    return render(request, 'employee/register_employee.html', {
        'user_form': user_form,
        'employee_form': employee_form
    })

@login_required
@user_passes_test(is_admin)
@transaction.atomic
def edit_employee(request, employee_id):
    """View to edit an existing employee"""
    employee = get_object_or_404(Employee, id=employee_id)
    
    if request.method == 'POST':
        user_form = UserUpdateForm(request.POST, instance=employee.user)
        employee_form = EmployeeUpdateForm(request.POST, instance=employee)
        
        if user_form.is_valid() and employee_form.is_valid():
            user_form.save()
            employee_form.save()
            messages.success(request, f'Employee {employee.full_name} has been updated successfully.')
            return redirect('employee_list')
    else:
        user_form = UserUpdateForm(instance=employee.user)
        employee_form = EmployeeUpdateForm(instance=employee)
    
    return render(request, 'employee/edit_employee.html', {
        'user_form': user_form,
        'employee_form': employee_form,
        'employee': employee
    })

@login_required
@user_passes_test(is_admin)
def employee_detail(request, employee_id):
    """View to show employee details"""
    employee = get_object_or_404(Employee, id=employee_id)
    current_year = timezone.now().year
    current_month = timezone.now().month
    
    active_days = LoginActivity.get_active_days_in_month(employee, current_year, current_month)
    
    login_activities = LoginActivity.objects.filter(
        employee=employee
    ).order_by('-login_date')[:10]  # Get last 10 login activities
    
    context = {
        'employee': employee,
        'active_days': active_days,
        'current_month': datetime(current_year, current_month, 1).strftime('%B %Y'),
        'login_activities': login_activities
    }
    
    return render(request, 'employee/employee_detail.html', context)

@login_required
@user_passes_test(is_admin)
def reset_password(request, employee_id):
    """View to reset employee password"""
    employee = get_object_or_404(Employee, id=employee_id)
    
    if request.method == 'POST':
        password = request.POST.get('password')
        confirm_password = request.POST.get('confirm_password')
        
        if password and password == confirm_password:
            user = employee.user
            user.set_password(password)
            user.save()
            messages.success(request, f'Password for {employee.full_name} has been reset successfully.')
            return redirect('employee_detail', employee_id=employee.id)
        else:
            messages.error(request, 'Passwords do not match.')
    
    return render(request, 'employee/reset_password.html', {'employee': employee})

# API view for Android app login tracking
from django.http import JsonResponse
from django.views.decorators.csrf import csrf_exempt
import json

@csrf_exempt
def record_login(request):
    """API endpoint to record login from Android app"""
    if request.method == 'POST':
        try:
            data = json.loads(request.body)
            username = data.get('username')
            device_id = data.get('device_id')
            device_name = data.get('device_name')
            
            try:
                user = User.objects.get(username=username)
                employee = Employee.objects.get(user=user)
                
                today = timezone.now().date()
                current_time = timezone.now().time()
                
                # Check if login already recorded for today
                login_exists = LoginActivity.objects.filter(
                    employee=employee,
                    login_date=today
                ).exists()
                
                if not login_exists:
                    LoginActivity.objects.create(
                        employee=employee,
                        login_date=today,
                        login_time=current_time,
                        device_id=device_id,
                        device_name=device_name
                    )
                    
                return JsonResponse({'status': 'success', 'message': 'Login recorded successfully'})
                
            except (User.DoesNotExist, Employee.DoesNotExist):
                return JsonResponse({'status': 'error', 'message': 'User not found'}, status=404)
                
        except json.JSONDecodeError:
            return JsonResponse({'status': 'error', 'message': 'Invalid JSON'}, status=400)
    
    return JsonResponse({'status': 'error', 'message': 'Invalid request method'}, status=405)
