# Invoicing System Setup Guide

## Overview
This invoicing system allows users to create professional invoices for contract customers by filtering parcels by date range, destination, and searching by waybill number. The system includes contract customer management and professional invoice generation with company branding.

## Features
- **Contract Customer Management**: Add and manage contract customers with company details, contact information, and payment terms
- **Invoice Creation**: Create invoices by selecting customers and filtering parcels by date range and destination
- **Parcel Search**: Search for specific parcels by waybill number and add them to invoices
- **Professional Invoices**: Generate professional invoices with company branding (Ficma Home Logistics)
- **Print Support**: Print-ready invoice templates with proper formatting

## Database Setup

### 1. Remote Database Migration
Run the SQL migration script on the remote database used by the .NET API:

```sql
-- Execute the invoicing_tables_migration.sql script
-- This creates the necessary tables for the invoicing system
```

### 2. Django Database Configuration
The Django settings have been configured with the remote database connection:

```python
# In ficma_dispatch/settings.py
DATABASES = {
    'default': {
        'ENGINE': 'django.db.backends.sqlite3',
        'NAME': BASE_DIR / 'db.sqlite3',
    },
    'invoicing': {
        'ENGINE': 'django.db.backends.postgresql',
        'NAME': 'ficma_wms',
        'USER': 'wms_user',
        'PASSWORD': '2019@_Ficma',
        'HOST': '139.59.12.69',
        'PORT': '5432',
    }
}
```

## System Components

### 1. Models
- **ContractCustomer**: Stores contract customer information
- **Invoice**: Stores invoice details and totals
- **InvoiceItem**: Stores individual parcels/items in invoices

### 2. Views
- **ContractCustomerListView**: List and manage contract customers
- **ContractCustomerCreateView**: Create new contract customers
- **InvoiceCreateView**: Create new invoices
- **InvoiceParcelSelectionView**: Select parcels for invoices
- **InvoiceDetailView**: View invoice details
- **InvoiceListView**: List all invoices
- **InvoicePrintView**: Print professional invoices

### 3. Templates
- `contract_customers.html`: List contract customers
- `contract_customer_form.html`: Add/edit contract customers
- `invoice_create.html`: Create new invoices
- `invoice_parcel_selection.html`: Select parcels for invoices
- `invoice_detail.html`: View invoice details
- `invoice_list.html`: List all invoices
- `invoice_print.html`: Professional invoice print template

## Usage Workflow

### 1. Add Contract Customers
1. Navigate to `/customers/`
2. Click "Add Customer"
3. Fill in customer details (name, company, contact info, payment terms, tax rate)
4. Save the customer

### 2. Create Invoices
1. Navigate to `/invoices/create/`
2. Select a contract customer
3. Set date range and destination filters
4. Click "Create Invoice"

### 3. Add Parcels to Invoice
1. On the parcel selection page, you can:
   - Browse available contract parcels filtered by your criteria
   - Search for specific parcels by waybill number
   - Add parcels to the invoice
   - Remove parcels from the invoice
2. The system automatically calculates totals and tax

### 4. View and Print Invoices
1. Navigate to `/invoices/` to see all invoices
2. Click "View" to see invoice details
3. Click "Print" to generate a professional invoice

## Company Branding
The system includes professional branding for "Ficma Home Logistics":
- Company Name: Ficma Home Logistics
- Email: ficmahomelogistics19@gmail.com
- Phone: +254707136852

## URL Structure
- `/customers/` - List contract customers
- `/customers/create/` - Add new customer
- `/invoices/` - List all invoices
- `/invoices/create/` - Create new invoice
- `/invoices/parcel-selection/` - Select parcels for invoice
- `/invoices/<id>/` - View invoice details
- `/invoices/<id>/print/` - Print invoice

## Security
- All invoicing features require administrator access
- Users must be authenticated to access the system
- Proper validation and error handling throughout

## Technical Details

### Database Tables
- **ContractCustomers**: Customer information and settings
- **Invoices**: Invoice headers and totals
- **InvoiceItems**: Individual parcels in invoices

### Key Features
- **Automatic Calculations**: Subtotal, tax, and total amounts are calculated automatically
- **Unique Constraints**: Prevents duplicate parcels in the same invoice
- **Professional Formatting**: Print-ready invoices with proper styling
- **Search Functionality**: Find parcels by waybill number
- **Filtering**: Filter parcels by date range and destination

### Error Handling
- Comprehensive error handling for API calls
- User-friendly error messages
- Validation for all form inputs
- Graceful fallbacks when API is unavailable

## Deployment Notes
1. ✅ Remote database connection configured and tested
2. ✅ Database tables created successfully
3. ✅ Django migrations applied to remote database
4. ✅ Invoicing system integrated into reports dashboard
5. ✅ All templates and views implemented
6. ✅ Professional invoice templates with company branding ready

**System Status**: Ready for production use

## Support
For technical support or questions about the invoicing system, contact the development team. 