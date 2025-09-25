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
    confirm_password = forms.CharField(widget=forms.PasswordInput(attrs={'class': 'form-control'}), required=True)
    role = forms.ChoiceField(required=True, widget=forms.Select(attrs={'class': 'form-control'}))
    branch = forms.ChoiceField(required=True, widget=forms.Select(attrs={'class': 'form-control'}))

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

    def clean(self):
        cleaned_data = super().clean()
        password = cleaned_data.get('password')
        confirm_password = cleaned_data.get('confirm_password')

        if password and confirm_password and password != confirm_password:
            raise forms.ValidationError("Passwords don't match")
        return cleaned_data

class UserUpdateForm(forms.Form):
    username = forms.CharField(max_length=150, required=True, widget=forms.TextInput(attrs={'class': 'form-control'}))
    email = forms.EmailField(required=True, widget=forms.EmailInput(attrs={'class': 'form-control'}))
    first_name = forms.CharField(max_length=150, required=False, widget=forms.TextInput(attrs={'class': 'form-control'}))
    last_name = forms.CharField(max_length=150, required=False, widget=forms.TextInput(attrs={'class': 'form-control'}))
    password = forms.CharField(widget=forms.PasswordInput(attrs={'class': 'form-control'}), required=False)
    role = forms.ChoiceField(required=True, widget=forms.Select(attrs={'class': 'form-control'}))

class ChangePasswordForm(forms.Form):
    new_password = forms.CharField(widget=forms.PasswordInput(attrs={'class': 'form-control'}), required=True)
    confirm_password = forms.CharField(widget=forms.PasswordInput(attrs={'class': 'form-control'}), required=True)

    def clean(self):
        cleaned_data = super().clean()
        password = cleaned_data.get('new_password')
        confirm_password = cleaned_data.get('confirm_password')

        if password and confirm_password and password != confirm_password:
            raise forms.ValidationError("Passwords don't match")
        return cleaned_data

class RoleCreateForm(forms.Form):
    name = forms.CharField(max_length=20, required=True, widget=forms.TextInput(attrs={'class': 'form-control'}))
    description = forms.CharField(max_length=200, required=False, widget=forms.Textarea(attrs={'class': 'form-control', 'rows': 3}))

class DeviceFilterForm(forms.Form):
    device_type = forms.ChoiceField(
        choices=[('', 'All Types'), ('android', 'Android'), ('ios', 'iOS'), ('web', 'Web'), ('other', 'Other')],
        required=False,
        widget=forms.Select(attrs={'class': 'form-control'})
    )
    is_active = forms.ChoiceField(
        choices=[('', 'All'), ('true', 'Active'), ('false', 'Inactive')],
        required=False,
        widget=forms.Select(attrs={'class': 'form-control'})
    )

class ActivityFilterForm(forms.Form):
    user_id = forms.ChoiceField(required=False, widget=forms.Select(attrs={'class': 'form-control'}))
    activity_type = forms.ChoiceField(
        choices=[
            ('', 'All Activities'),
            ('login', 'Login'),
            ('logout', 'Logout'),
            ('create', 'Create'),
            ('update', 'Update'),
            ('delete', 'Delete'),
            ('view', 'View'),
            ('export', 'Export'),
            ('import', 'Import')
        ],
        required=False,
        widget=forms.Select(attrs={'class': 'form-control'})
    )
    date_from = forms.DateField(required=False, widget=forms.DateInput(attrs={'type': 'date', 'class': 'form-control'}))
    date_to = forms.DateField(required=False, widget=forms.DateInput(attrs={'type': 'date', 'class': 'form-control'})) 