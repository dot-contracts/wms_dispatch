from django.db import models
from django.contrib.auth.models import User
import uuid
from datetime import datetime

class ParcelStatus(models.IntegerChoices):
    PENDING = 0, 'Pending'
    FINALIZED = 1, 'Finalized'
    IN_TRANSIT = 2, 'In Transit'
    DELIVERED = 3, 'Delivered'
    CANCELLED = 4, 'Cancelled'

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

class UserProfile(models.Model):
    """Model extending the User model to store additional information"""
    user = models.OneToOneField(User, on_delete=models.CASCADE, related_name='profile')
    branch = models.ForeignKey(Branch, on_delete=models.SET_NULL, null=True, blank=True, related_name='users')
    is_branch_manager = models.BooleanField(default=False)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

    def __str__(self):
        branch_name = self.branch.name if self.branch else "No Branch"
        role = "Branch Manager" if self.is_branch_manager else "Staff"
        return f"{self.user.username} - {branch_name} ({role})"

class Parcel(models.Model):
    id = models.UUIDField(primary_key=True, default=uuid.uuid4, editable=False)
    created_at = models.DateTimeField(auto_now_add=True)
    waybill_number = models.CharField(max_length=50, null=True, blank=True)
    qr_code = models.CharField(max_length=50, null=True, blank=True)
    dispatched_at = models.DateTimeField(null=True, blank=True)
    dispatch_tracking_code = models.CharField(max_length=50, null=True, blank=True)
    
    # Sender Details
    sender = models.CharField(max_length=100)
    sender_telephone = models.CharField(max_length=20)
    
    # Receiver Details
    receiver = models.CharField(max_length=100)
    receiver_telephone = models.CharField(max_length=20)
    destination = models.CharField(max_length=100)
    
    # Parcel Description
    quantity = models.IntegerField(default=1)
    description = models.TextField()
    amount = models.DecimalField(max_digits=10, decimal_places=2)
    rate = models.DecimalField(max_digits=10, decimal_places=2)
    payment_methods = models.CharField(max_length=50)
    
    # Calculated Properties
    total_amount = models.DecimalField(max_digits=10, decimal_places=2)
    total_rate = models.DecimalField(max_digits=10, decimal_places=2)
    
    # Status
    status = models.IntegerField(choices=ParcelStatus.choices, default=ParcelStatus.PENDING)
    
    def __str__(self):
        return f"{self.waybill_number} - {self.receiver}"

    def save(self, *args, **kwargs):
        # Calculate total_amount and total_rate if not set
        if not self.total_amount:
            self.total_amount = self.amount * self.quantity
        if not self.total_rate:
            self.total_rate = self.rate * self.quantity
        super().save(*args, **kwargs)

class Dispatch(models.Model):
    id = models.UUIDField(primary_key=True, default=uuid.uuid4, editable=False)
    dispatch_date = models.DateTimeField(auto_now_add=True)
    destination = models.CharField(max_length=100)
    dispatch_code = models.CharField(max_length=50, unique=True)
    vehicle_registration = models.CharField(max_length=20, null=True, blank=True)
    driver_name = models.CharField(max_length=100, null=True, blank=True)
    total_parcels = models.IntegerField(default=0)
    total_amount = models.DecimalField(max_digits=12, decimal_places=2, default=0)
    status = models.IntegerField(choices=ParcelStatus.choices, default=ParcelStatus.IN_TRANSIT)
    
    def __str__(self):
        return f"Dispatch {self.dispatch_code} to {self.destination}"

class DispatchParcel(models.Model):
    dispatch = models.ForeignKey(Dispatch, on_delete=models.CASCADE, related_name='parcels')
    parcel = models.ForeignKey(Parcel, on_delete=models.CASCADE)
    
    class Meta:
        unique_together = ('dispatch', 'parcel')
    
    def __str__(self):
        return f"{self.dispatch.dispatch_code} - {self.parcel.waybill_number}"
