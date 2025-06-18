from django import forms
from django.core.validators import EmailValidator
import requests
from django.conf import settings
import json
import logging

logger = logging.getLogger(__name__)

class UserRegistrationForm(forms.Form):
    username = forms.CharField(max_length=150, required=True, widget=forms.TextInput(attrs={'class': 'form-control'}))
    email = forms.EmailField(validators=[EmailValidator()], required=True, widget=forms.EmailInput(attrs={'class': 'form-control'}))
    first_name = forms.CharField(max_length=150, required=False, widget=forms.TextInput(attrs={'class': 'form-control'}))
    last_name = forms.CharField(max_length=150, required=False, widget=forms.TextInput(attrs={'class': 'form-control'}))
    password = forms.CharField(widget=forms.PasswordInput(attrs={'class': 'form-control'}), required=True)
    role = forms.ChoiceField(required=True, widget=forms.Select(attrs={'class': 'form-control'}))

    def __init__(self, *args, **kwargs):
        super().__init__(*args, **kwargs)
        self.fields['role'].choices = self._get_role_choices()

    def _get_role_choices(self):
        choices = [('', 'Select a role')]
        try:
            response = requests.get(f"{settings.API_BASE_URL}/api/Roles")
            if response.status_code == 200:
                roles = response.json()
                # Handle cases where the response might be a dictionary with '$values'
                if isinstance(roles, dict) and '$values' in roles:
                    roles = roles['$values']
                
                if isinstance(roles, list):
                    for role in roles:
                        choices.append((role['id'], role['name']))
            else:
                logger.error(f"Failed to fetch roles from API: {response.text}")
        except requests.RequestException as e:
            logger.error(f"Error connecting to API to fetch roles: {e}")
        
        return choices

    def clean_username(self):
        username = self.cleaned_data['username']
        try:
            # Check if username exists in API
            response = requests.get(f"{settings.API_BASE_URL}/api/Users")
            if response.status_code == 200:
                users = response.json()
                if isinstance(users, list) and any(user.get('username') == username for user in users):
                    raise forms.ValidationError("Username already exists")
            return username
        except Exception as e:
            # Log the error but don't block registration
            logger.error(f"Error checking username: {str(e)}")
            return username

    def clean_email(self):
        email = self.cleaned_data['email']
        try:
            # Check if email exists in API
            response = requests.get(f"{settings.API_BASE_URL}/api/Users")
            if response.status_code == 200:
                users = response.json()
                if isinstance(users, list) and any(user.get('email') == email for user in users):
                    raise forms.ValidationError("Email already exists")
            return email
        except Exception as e:
            # Log the error but don't block registration
            logger.error(f"Error checking email: {str(e)}")
            return email

class UserUpdateForm(forms.Form):
    username = forms.CharField(max_length=150, required=True, widget=forms.TextInput(attrs={'class': 'form-control'}))
    email = forms.EmailField(validators=[EmailValidator()], required=True, widget=forms.EmailInput(attrs={'class': 'form-control'}))
    first_name = forms.CharField(max_length=150, required=False, widget=forms.TextInput(attrs={'class': 'form-control'}))
    last_name = forms.CharField(max_length=150, required=False, widget=forms.TextInput(attrs={'class': 'form-control'}))
    role = forms.ChoiceField(required=True, widget=forms.Select(attrs={'class': 'form-control'}))
    password = forms.CharField(widget=forms.PasswordInput(attrs={'class': 'form-control'}), required=False)

    def __init__(self, *args, **kwargs):
        super().__init__(*args, **kwargs)
        self.fields['role'].choices = self._get_role_choices()

    def _get_role_choices(self):
        choices = [('', 'Select a role')]
        try:
            response = requests.get(f"{settings.API_BASE_URL}/api/Roles")
            if response.status_code == 200:
                roles = response.json()
                 # Handle cases where the response might be a dictionary with '$values'
                if isinstance(roles, dict) and '$values' in roles:
                    roles = roles['$values']

                if isinstance(roles, list):
                    for role in roles:
                        choices.append((role['id'], role['name']))
            else:
                logger.error(f"Failed to fetch roles from API: {response.text}")
        except requests.RequestException as e:
            logger.error(f"Error connecting to API to fetch roles: {e}")
        
        return choices

class ChangePasswordForm(forms.Form):
    new_password = forms.CharField(widget=forms.PasswordInput(attrs={'class': 'form-control'}), required=True)
    confirm_password = forms.CharField(widget=forms.PasswordInput(attrs={'class': 'form-control'}), required=True)

    def clean(self):
        cleaned_data = super().clean()
        new_password = cleaned_data.get('new_password')
        confirm_password = cleaned_data.get('confirm_password')

        if new_password and confirm_password and new_password != confirm_password:
            raise forms.ValidationError("Passwords don't match")
        return cleaned_data 