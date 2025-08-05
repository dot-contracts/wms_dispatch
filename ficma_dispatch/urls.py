"""
URL configuration for ficma_dispatch project.

The `urlpatterns` list routes URLs to views. For more information please see:
    https://docs.djangoproject.com/en/5.2/topics/http/urls/
Examples:
Function views
    1. Add an import:  from my_app import views
    2. Add a URL to urlpatterns:  path('', views.home, name='home')
Class-based views
    1. Add an import:  from other_app.views import Home
    2. Add a URL to urlpatterns:  path('', Home.as_view(), name='home')
Including another URLconf
    1. Import the include() function: from django.urls import include, path
    2. Add a URL to urlpatterns:  path('blog/', include('blog.urls'))
"""
from django.contrib import admin
from django.urls import path, include
from django.conf import settings
from django.conf.urls.static import static
from rest_framework.routers import DefaultRouter
from dispatch.views import (
    ParcelViewSet, DispatchViewSet, 
    DashboardView, ParcelListView, ParcelDetailView,
    DispatchListView, DispatchDetailView, CreateDispatchView,
    login_view, logout_view, ConsignmentNoteView, DispatchNoteView,
    ReportsView, SalesPerClerkReportView, ContractInvoicesReportView,
    UndeliveredParcelsReportView, CODDeliveredReportView, DeliveryRateReportView,
    ParcelListReportView, DebugAuthView,
    ContractCustomerListView, ContractCustomerCreateView,
    InvoiceCreateView, InvoiceParcelSelectionView, InvoiceDetailView,
    InvoiceListView, InvoicePrintView
)

# REST API routes
router = DefaultRouter()
router.register(r'parcels', ParcelViewSet, basename='parcel')
router.register(r'dispatches', DispatchViewSet, basename='dispatch')
    
    # API URLs
api_urlpatterns = [
    path('', include(router.urls)),
]
    
    # Web URLs
web_urlpatterns = [
    path('', DashboardView.as_view(), name='dashboard'),
    path('parcels/', ParcelListView.as_view(), name='parcel_list'),
    path('parcels/<uuid:parcel_id>/', ParcelDetailView.as_view(), name='parcel_detail'),
    path('dispatches/', DispatchListView.as_view(), name='dispatch_list'),
    path('dispatches/create/', CreateDispatchView.as_view(), name='create_dispatch'),
    path('dispatches/<uuid:dispatch_id>/', DispatchDetailView.as_view(), name='dispatch_detail'),
    path('dispatches/<uuid:dispatch_id>/note/', DispatchNoteView.as_view(), name='dispatch_note'),
    path('parcels/<uuid:parcel_id>/consignment-note/', ConsignmentNoteView.as_view(), name='consignment_note'),
    
    # Reports URLs
    path('reports/', ReportsView.as_view(), name='reports_dashboard'),
    path('reports/sales-per-clerk/', SalesPerClerkReportView.as_view(), name='sales_per_clerk_report'),
    path('reports/contract-invoices/', ContractInvoicesReportView.as_view(), name='contract_invoices_report'),
    path('reports/undelivered-parcels/', UndeliveredParcelsReportView.as_view(), name='undelivered_parcels_report'),
    path('reports/cod-delivered/', CODDeliveredReportView.as_view(), name='cod_delivered_report'),
    path('reports/delivery-rate/', DeliveryRateReportView.as_view(), name='delivery_rate_report'),
    path('reports/parcel-list/', ParcelListReportView.as_view(), name='parcel_list_report'),
    
    # Contract Customer Management URLs
    path('customers/', ContractCustomerListView.as_view(), name='contract_customers'),
    path('customers/create/', ContractCustomerCreateView.as_view(), name='contract_customer_create'),
    
    # Invoice Management URLs
    path('invoices/', InvoiceListView.as_view(), name='invoice_list'),
    path('invoices/create/', InvoiceCreateView.as_view(), name='invoice_create'),
    path('invoices/parcel-selection/', InvoiceParcelSelectionView.as_view(), name='invoice_parcel_selection'),
    path('invoices/<int:invoice_id>/', InvoiceDetailView.as_view(), name='invoice_detail'),
    path('invoices/<int:invoice_id>/print/', InvoicePrintView.as_view(), name='invoice_print'),
    
    # Debug URLs
    path('debug/auth/', DebugAuthView.as_view(), name='debug_auth'),
]

# Authentication URLs
auth_urlpatterns = [
    path('login/', login_view, name='login'),
    path('logout/', logout_view, name='logout'),
]

urlpatterns = [
    path('admin/', admin.site.urls),
    path('api/', include(api_urlpatterns)),
    path('', include(web_urlpatterns)),
    path('', include(auth_urlpatterns)),
    path('users/', include('user_management.urls')),
]

if settings.DEBUG:
    urlpatterns += static(settings.MEDIA_URL, document_root=settings.MEDIA_ROOT)
    urlpatterns += static(settings.STATIC_URL, document_root=settings.STATIC_ROOT)
