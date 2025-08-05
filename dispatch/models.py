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

# New models for contract customers and invoicing
class ContractCustomer(models.Model):
    """Model for contract customers who receive invoices"""
    name = models.CharField(max_length=200)
    company_name = models.CharField(max_length=200, blank=True)
    email = models.EmailField(blank=True)
    phone = models.CharField(max_length=20, blank=True)
    address = models.TextField(blank=True)
    contact_person = models.CharField(max_length=100, blank=True)
    contract_number = models.CharField(max_length=50, blank=True)
    payment_terms = models.CharField(max_length=100, default="Net 30")
    tax_rate = models.DecimalField(max_digits=5, decimal_places=2, default=0.00)
    is_active = models.BooleanField(default=True)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    created_by = models.ForeignKey(User, on_delete=models.SET_NULL, null=True, blank=True)
    api_user_id = models.IntegerField(null=True, blank=True)  # Store API user ID
    api_username = models.CharField(max_length=150, blank=True)  # Store API username
    
    class Meta:
        ordering = ['name']
        db_table = 'ContractCustomers'
    
    def __str__(self):
        return f"{self.name} - {self.company_name}" if self.company_name else self.name

class Invoice(models.Model):
    """Model for invoices generated for contract customers"""
    INVOICE_STATUS_CHOICES = [
        ('draft', 'Draft'),
        ('sent', 'Sent'),
        ('paid', 'Paid'),
        ('overdue', 'Overdue'),
        ('cancelled', 'Cancelled'),
    ]
    
    invoice_number = models.CharField(max_length=50, unique=True)
    customer = models.ForeignKey(ContractCustomer, on_delete=models.CASCADE)
    issue_date = models.DateField()
    due_date = models.DateField()
    status = models.CharField(max_length=20, choices=INVOICE_STATUS_CHOICES, default='draft')
    subtotal = models.DecimalField(max_digits=12, decimal_places=2, default=0.00)
    tax_amount = models.DecimalField(max_digits=12, decimal_places=2, default=0.00)
    total_amount = models.DecimalField(max_digits=12, decimal_places=2, default=0.00)
    notes = models.TextField(blank=True)
    created_by = models.ForeignKey(User, on_delete=models.SET_NULL, null=True, blank=True)
    api_user_id = models.IntegerField(null=True, blank=True)  # Store API user ID
    api_username = models.CharField(max_length=150, blank=True)  # Store API username
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    
    class Meta:
        ordering = ['-issue_date']
        db_table = 'Invoices'
    
    def __str__(self):
        return f"Invoice {self.invoice_number} - {self.customer.name}"
    
    def save(self, *args, **kwargs):
        # Auto-calculate total if not set
        if not self.total_amount:
            self.total_amount = self.subtotal + self.tax_amount
        super().save(*args, **kwargs)

class InvoiceItem(models.Model):
    """Model for individual items/parcels in an invoice"""
    invoice = models.ForeignKey(Invoice, on_delete=models.CASCADE, related_name='items')
    parcel_id = models.CharField(max_length=100)  # API parcel ID
    waybill_number = models.CharField(max_length=50)
    description = models.CharField(max_length=200)
    quantity = models.IntegerField(default=1)
    unit_price = models.DecimalField(max_digits=10, decimal_places=2)
    total_price = models.DecimalField(max_digits=10, decimal_places=2)
    created_at = models.DateTimeField(auto_now_add=True)
    
    class Meta:
        unique_together = ['invoice', 'parcel_id']
        db_table = 'InvoiceItems'
    
    def __str__(self):
        return f"{self.waybill_number} - {self.description}"

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
