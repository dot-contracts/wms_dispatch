from django.db import models
from django.contrib.auth.models import User
import datetime

class Branch(models.Model):
    """Model representing a branch/destination zone"""
    name = models.CharField(max_length=100, unique=True)
    description = models.TextField(blank=True, null=True)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

    def __str__(self):
        return self.name

    class Meta:
        verbose_name_plural = "Branches"

class Role(models.Model):
    """Model representing user roles in the system"""
    ROLE_CHOICES = (
        ('admin', 'Admin'),
        ('clerk', 'Clerk'),
        ('dispatcher', 'Dispatcher'),
        ('manager', 'Manager'),
    )
    name = models.CharField(max_length=20, choices=ROLE_CHOICES, unique=True)
    description = models.TextField(blank=True, null=True)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

    def __str__(self):
        return self.get_name_display()

class Employee(models.Model):
    """Model representing an employee"""
    user = models.OneToOneField(User, on_delete=models.CASCADE, related_name='employee')
    employee_id = models.CharField(max_length=20, unique=True)
    phone_number = models.CharField(max_length=15)
    id_number = models.CharField(max_length=20, unique=True)
    roles = models.ManyToManyField(Role, related_name='employees')
    branches = models.ManyToManyField(Branch, related_name='employees')
    is_active = models.BooleanField(default=True)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

    def __str__(self):
        return f"{self.user.first_name} {self.user.last_name} ({self.employee_id})"
    
    @property
    def full_name(self):
        return f"{self.user.first_name} {self.user.last_name}"

class LoginActivity(models.Model):
    """Model to track employee login activities"""
    employee = models.ForeignKey(Employee, on_delete=models.CASCADE, related_name='login_activities')
    login_date = models.DateField()
    login_time = models.TimeField()
    device_id = models.CharField(max_length=100, blank=True, null=True)
    device_name = models.CharField(max_length=100, blank=True, null=True)
    created_at = models.DateTimeField(auto_now_add=True)

    def __str__(self):
        return f"{self.employee} - {self.login_date}"
    
    class Meta:
        verbose_name_plural = "Login Activities"
        unique_together = ('employee', 'login_date')  # One login record per day per employee

    @classmethod
    def get_active_days_in_month(cls, employee, year, month):
        """Get the number of active days for an employee in a specific month"""
        start_date = datetime.date(year, month, 1)
        if month == 12:
            end_date = datetime.date(year + 1, 1, 1) - datetime.timedelta(days=1)
        else:
            end_date = datetime.date(year, month + 1, 1) - datetime.timedelta(days=1)
            
        return cls.objects.filter(
            employee=employee,
            login_date__range=(start_date, end_date)
        ).count()
