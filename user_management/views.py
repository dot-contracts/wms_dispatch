from django.shortcuts import render, redirect, get_object_or_404
from django.contrib.auth.decorators import login_required, user_passes_test
from django.contrib import messages
from .forms import UserRegistrationForm, UserUpdateForm, ChangePasswordForm
import requests
from django.conf import settings
import logging

logger = logging.getLogger(__name__)

def is_admin(user):
    return user.is_staff

@login_required
@user_passes_test(is_admin)
def user_list(request):
    try:
        response = requests.get(f"{settings.API_BASE_URL}/api/Users")
        if response.status_code == 200:
            users = response.json()
            return render(request, 'user_management/user_list.html', {'users': users})
        else:
            messages.error(request, f"Failed to fetch users from API: {response.text}")
            return render(request, 'user_management/user_list.html', {'users': []})
    except Exception as e:
        logger.error(f"Error fetching users: {str(e)}")
        messages.error(request, "Error connecting to the API. Please try again later.")
        return render(request, 'user_management/user_list.html', {'users': []})

def register_user(request):
    try:
        # Fetch roles and branches from the API
        roles_response = requests.get(f"{settings.API_BASE_URL}/api/Roles")
        branches_response = requests.get(f"{settings.API_BASE_URL}/api/Branches")

        if roles_response.status_code != 200 or branches_response.status_code != 200:
            messages.error(request, "Failed to load roles or branches from the API.")
            return render(request, 'user_management/register_user.html', {'form': UserRegistrationForm()})

        roles = roles_response.json()
        branches = branches_response.json()

        # Handle cases where the API wraps the response in a '$values' key
        roles_list = roles['$values'] if isinstance(roles, dict) and '$values' in roles else roles
        branches_list = branches['$values'] if isinstance(branches, dict) and '$values' in branches else branches

        role_choices = [(role['id'], role['name']) for role in roles_list]
        branch_choices = [(branch['id'], branch['name']) for branch in branches_list]

    except requests.exceptions.RequestException as e:
        logger.error(f"API request failed: {e}")
        messages.error(request, "Error connecting to the API. Please try again later.")
        return render(request, 'user_management/register_user.html', {'form': UserRegistrationForm()})

    if request.method == 'POST':
        form = UserRegistrationForm(request.POST)
        form.fields['role'].choices = role_choices
        form.fields['branch'].choices = branch_choices
        if form.is_valid():
            try:
                data = {
                    'username': form.cleaned_data['username'],
                    'email': form.cleaned_data['email'],
                    'firstName': form.cleaned_data['first_name'],
                    'lastName': form.cleaned_data['last_name'],
                    'password': form.cleaned_data['password'],
                    'roleId': int(form.cleaned_data['role']),
                    'branchId': int(form.cleaned_data['branch'])
                }
                
                # Log the request data
                logger.debug(f"Attempting to create user with data: {data}")
                logger.debug(f"API URL: {settings.API_BASE_URL}/api/Users")
                
                try:
                    response = requests.post(
                        f"{settings.API_BASE_URL}/api/Users",
                        json=data,
                        headers={
                            'Content-Type': 'application/json'
                        },
                        timeout=10  # Add timeout
                    )
                    
                    # Log the response details
                    logger.debug(f"Response status code: {response.status_code}")
                    logger.debug(f"Response headers: {dict(response.headers)}")
                    logger.debug(f"Response content: {response.text}")
                    
                    if response.status_code == 201:
                        messages.success(request, "User created successfully")
                        return redirect('user_management:user_list')
                    else:
                        error_message = response.text
                        try:
                            error_json = response.json()
                            if isinstance(error_json, dict):
                                if 'message' in error_json:
                                    error_message = error_json['message']
                                elif 'error' in error_json:
                                    error_message = error_json['error']
                                elif 'errors' in error_json:
                                    error_message = str(error_json['errors'])
                        except Exception as json_error:
                            logger.error(f"Error parsing error response: {str(json_error)}")
                        
                        logger.error(f"Failed to create user. Status: {response.status_code}, Error: {error_message}")
                        messages.error(request, f"Failed to create user: {error_message}")
                except requests.exceptions.RequestException as req_error:
                    logger.error(f"Request error: {str(req_error)}", exc_info=True)
                    messages.error(request, f"Error connecting to the API: {str(req_error)}")
            except Exception as e:
                logger.error(f"Error creating user: {str(e)}", exc_info=True)
                messages.error(request, "Error connecting to the API. Please try again later.")
    else:
        form = UserRegistrationForm()
        form.fields['role'].choices = role_choices
        form.fields['branch'].choices = branch_choices
    
    return render(request, 'user_management/register_user.html', {'form': form})

@login_required
@user_passes_test(is_admin)
def update_user(request, user_id):
    try:
        # Get user data from API
        response = requests.get(f"{settings.API_BASE_URL}/api/Users/{user_id}")
        if response.status_code != 200:
            messages.error(request, "User not found")
            return redirect('user_management:user_list')
        
        user_data = response.json()

        # Fetch roles from the API
        roles_response = requests.get(f"{settings.API_BASE_URL}/api/Roles")
        if roles_response.status_code != 200:
            messages.error(request, "Failed to load roles from the API.")
            return redirect('user_management:user_list')
        
        roles_data = roles_response.json()
        roles_list = roles_data['$values'] if isinstance(roles_data, dict) and '$values' in roles_data else roles_data
        role_choices = [(role['id'], role['name']) for role in roles_list]
        
        if request.method == 'POST':
            form = UserUpdateForm(request.POST)
            form.fields['role'].choices = role_choices
            if form.is_valid():
                data = {
                    'id': user_id,
                    'username': form.cleaned_data['username'],
                    'email': form.cleaned_data['email'],
                    'firstName': form.cleaned_data['first_name'],
                    'lastName': form.cleaned_data['last_name'],
                    'roleId': int(form.cleaned_data['role'])
                }
                
                if form.cleaned_data['password']:
                    data['password'] = form.cleaned_data['password']
                
                response = requests.put(
                    f"{settings.API_BASE_URL}/api/Users/{user_id}",
                    json=data,
                    headers={
                        'Authorization': f'Bearer {request.session.get("api_token")}',
                        'Content-Type': 'application/json'
                    }
                )
                
                if response.status_code == 204:
                    messages.success(request, "User updated successfully")
                    return redirect('user_management:user_list')
                else:
                    error_message = response.text
                    try:
                        error_json = response.json()
                        if isinstance(error_json, dict) and 'message' in error_json:
                            error_message = error_json['message']
                    except:
                        pass
                    messages.error(request, f"Failed to update user: {error_message}")
        else:
            form = UserUpdateForm(initial={
                'username': user_data.get('username', ''),
                'email': user_data.get('email', ''),
                'first_name': user_data.get('firstName', ''),
                'last_name': user_data.get('lastName', ''),
                'role': user_data.get('role', {}).get('id', '')
            })
            form.fields['role'].choices = role_choices
        
        return render(request, 'user_management/update_user.html', {'form': form, 'user_id': user_id})
    except Exception as e:
        logger.error(f"Error updating user: {str(e)}")
        messages.error(request, "Error connecting to the API. Please try again later.")
        return redirect('user_management:user_list')

@login_required
@user_passes_test(is_admin)
def change_password(request, user_id):
    if request.method == 'POST':
        form = ChangePasswordForm(request.POST)
        if form.is_valid():
            try:
                data = {
                    'newPassword': form.cleaned_data['new_password']
                }
                
                response = requests.put(
                    f"{settings.API_BASE_URL}/api/Users/{user_id}/change-password",
                    json=data,
                    headers={
                        'Authorization': f'Bearer {request.session.get("api_token")}',
                        'Content-Type': 'application/json'
                    }
                )
                
                if response.status_code == 204:
                    messages.success(request, "Password changed successfully")
                    return redirect('user_management:user_list')
                else:
                    error_message = response.text
                    try:
                        error_json = response.json()
                        if isinstance(error_json, dict) and 'message' in error_json:
                            error_message = error_json['message']
                    except:
                        pass
                    messages.error(request, f"Failed to change password: {error_message}")
            except Exception as e:
                logger.error(f"Error changing password: {str(e)}")
                messages.error(request, "Error connecting to the API. Please try again later.")
    else:
        form = ChangePasswordForm()
    
    return render(request, 'user_management/change_password.html', {'form': form, 'user_id': user_id})
