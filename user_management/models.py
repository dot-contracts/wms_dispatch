from django.db import models
from django.contrib.auth.models import User
from django.utils import timezone
import uuid


class Role(models.Model):
    """Model representing user roles in the system"""
    ROLE_CHOICES = (
        ('admin', 'Administrator'),
        ('manager', 'Manager'),
        ('clerk', 'Clerk'),
        ('dispatcher', 'Dispatcher'),
        ('driver', 'Driver'),
        ('supervisor', 'Supervisor'),
    )
    
    name = models.CharField(max_length=20, choices=ROLE_CHOICES, unique=True)
    display_name = models.CharField(max_length=50)
    description = models.TextField(blank=True, null=True)
    permissions = models.JSONField(default=list, blank=True)  # Store permissions as JSON
    is_active = models.BooleanField(default=True)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    
    class Meta:
        ordering = ['display_name']
    
    def __str__(self):
        return self.display_name


class Branch(models.Model):
    """Model representing branches/locations"""
    name = models.CharField(max_length=100, unique=True)
    code = models.CharField(max_length=10, unique=True)
    address = models.TextField(blank=True, null=True)
    phone = models.CharField(max_length=20, blank=True, null=True)
    email = models.EmailField(blank=True, null=True)
    manager = models.ForeignKey(User, on_delete=models.SET_NULL, null=True, blank=True, related_name='managed_branches')
    is_active = models.BooleanField(default=True)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    
    class Meta:
        ordering = ['name']
    
    def __str__(self):
        return self.name


class UserProfile(models.Model):
    """Extended user profile with additional information"""
    user = models.OneToOneField(User, on_delete=models.CASCADE, related_name='profile')
    employee_id = models.CharField(max_length=20, unique=True, blank=True, null=True)
    phone_number = models.CharField(max_length=15, blank=True, null=True)
    id_number = models.CharField(max_length=20, unique=True, blank=True, null=True)
    roles = models.ManyToManyField(Role, related_name='users', blank=True)
    branches = models.ManyToManyField(Branch, related_name='users', blank=True)
    is_active = models.BooleanField(default=True)
    api_user_id = models.IntegerField(null=True, blank=True)  # Link to API user
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    
    class Meta:
        ordering = ['user__first_name', 'user__last_name']
    
    def __str__(self):
        return f"{self.user.get_full_name()} ({self.user.username})"
    
    @property
    def full_name(self):
        return self.user.get_full_name() or self.user.username
    
    @property
    def primary_role(self):
        return self.roles.first()


class Device(models.Model):
    """Model to track Android devices"""
    DEVICE_TYPES = (
        ('android', 'Android'),
        ('ios', 'iOS'),
        ('web', 'Web'),
        ('other', 'Other'),
    )
    
    serial_number = models.CharField(max_length=100, unique=True)
    device_name = models.CharField(max_length=100, blank=True, null=True)
    device_type = models.CharField(max_length=20, choices=DEVICE_TYPES, default='android')
    model = models.CharField(max_length=100, blank=True, null=True)
    manufacturer = models.CharField(max_length=100, blank=True, null=True)
    android_version = models.CharField(max_length=50, blank=True, null=True)
    app_version = models.CharField(max_length=20, blank=True, null=True)
    is_active = models.BooleanField(default=True)
    first_seen = models.DateTimeField(auto_now_add=True)
    last_seen = models.DateTimeField(auto_now=True)
    
    class Meta:
        ordering = ['-last_seen']
    
    def __str__(self):
        return f"{self.device_name or 'Unknown Device'} ({self.serial_number})"


class LoginSession(models.Model):
    """Model to track user login sessions and device usage"""
    user = models.ForeignKey(User, on_delete=models.CASCADE, related_name='login_sessions')
    device = models.ForeignKey(Device, on_delete=models.CASCADE, related_name='login_sessions')
    session_id = models.UUIDField(default=uuid.uuid4, unique=True)
    login_time = models.DateTimeField(auto_now_add=True)
    logout_time = models.DateTimeField(null=True, blank=True)
    ip_address = models.GenericIPAddressField(blank=True, null=True)
    user_agent = models.TextField(blank=True, null=True)
    is_active = models.BooleanField(default=True)
    location = models.CharField(max_length=200, blank=True, null=True)
    
    class Meta:
        ordering = ['-login_time']
    
    def __str__(self):
        return f"{self.user.username} - {self.device.device_name} ({self.login_time})"
    
    @property
    def duration(self):
        if self.logout_time:
            return self.logout_time - self.login_time
        elif self.is_active:
            return timezone.now() - self.login_time
        return None
    
    def end_session(self):
        """End the current session"""
        self.logout_time = timezone.now()
        self.is_active = False
        self.save()


class UserActivity(models.Model):
    """Model to track user activities"""
    ACTIVITY_TYPES = (
        ('login', 'Login'),
        ('logout', 'Logout'),
        ('create', 'Create'),
        ('update', 'Update'),
        ('delete', 'Delete'),
        ('view', 'View'),
        ('export', 'Export'),
        ('import', 'Import'),
    )
    
    user = models.ForeignKey(User, on_delete=models.CASCADE, related_name='activities')
    activity_type = models.CharField(max_length=20, choices=ACTIVITY_TYPES)
    description = models.CharField(max_length=200)
    details = models.JSONField(default=dict, blank=True)
    ip_address = models.GenericIPAddressField(blank=True, null=True)
    user_agent = models.TextField(blank=True, null=True)
    timestamp = models.DateTimeField(auto_now_add=True)
    
    class Meta:
        ordering = ['-timestamp']
    
    def __str__(self):
        return f"{self.user.username} - {self.activity_type} - {self.description}"


class SystemSettings(models.Model):
    """Model for system-wide settings"""
    key = models.CharField(max_length=100, unique=True)
    value = models.TextField()
    description = models.TextField(blank=True, null=True)
    updated_by = models.ForeignKey(User, on_delete=models.SET_NULL, null=True, blank=True)
    updated_at = models.DateTimeField(auto_now=True)
    
    def __str__(self):
        return f"{self.key}: {self.value}"
