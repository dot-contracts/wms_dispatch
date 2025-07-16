from django.db import models
from django.contrib.auth.models import User
from django.utils import timezone
import json

# Existing models...
class Branch(models.Model):
    name = models.CharField(max_length=100)
    address = models.TextField(blank=True)
    phone = models.CharField(max_length=20, blank=True)
    email = models.EmailField(blank=True)
    
    def __str__(self):
        return self.name

class UserProfile(models.Model):
    user = models.OneToOneField(User, on_delete=models.CASCADE)
    branch = models.ForeignKey(Branch, on_delete=models.SET_NULL, null=True, blank=True)
    api_user_id = models.IntegerField(null=True, blank=True)
    
    def __str__(self):
        return f"{self.user.username} - {self.branch.name if self.branch else 'No Branch'}"

# New models for shared dispatch drafts
class DispatchDraft(models.Model):
    """
    Shared dispatch drafts that can be accessed by multiple users
    """
    destination = models.CharField(max_length=100)
    vehicle_registration = models.CharField(max_length=50, blank=True, null=True)
    driver_name = models.CharField(max_length=100, blank=True, null=True)
    created_by = models.ForeignKey(User, on_delete=models.CASCADE, related_name='created_drafts')
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    updated_by = models.ForeignKey(User, on_delete=models.CASCADE, related_name='updated_drafts')
    is_active = models.BooleanField(default=True)
    
    # Optional: Restrict access to specific branch
    branch = models.ForeignKey(Branch, on_delete=models.CASCADE, null=True, blank=True)
    
    class Meta:
        unique_together = ['destination', 'branch', 'is_active']
        ordering = ['-updated_at']
    
    def __str__(self):
        return f"Draft for {self.destination} (by {self.created_by.username})"
    
    @property
    def parcel_count(self):
        return self.parcel_drafts.count()
    
    @property
    def parcel_ids(self):
        return list(self.parcel_drafts.values_list('parcel_id', flat=True))

class DraftParcel(models.Model):
    """
    Individual parcels in a dispatch draft
    """
    draft = models.ForeignKey(DispatchDraft, on_delete=models.CASCADE, related_name='parcel_drafts')
    parcel_id = models.CharField(max_length=100)  # API parcel ID
    added_by = models.ForeignKey(User, on_delete=models.CASCADE)
    added_at = models.DateTimeField(auto_now_add=True)
    
    class Meta:
        unique_together = ['draft', 'parcel_id']
    
    def __str__(self):
        return f"Parcel {self.parcel_id} in {self.draft.destination} draft"
