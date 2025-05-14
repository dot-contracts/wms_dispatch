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
from django.contrib.auth.decorators import login_required
from rest_framework.routers import DefaultRouter
from dispatch.views import (
    ParcelViewSet, DispatchViewSet, 
    DashboardView, ParcelListView, ParcelDetailView, ConsignmentNoteView,
    DispatchListView, DispatchDetailView, DispatchNoteView, CreateDispatchView,
    login_view, logout_view
)

# REST API routes
router = DefaultRouter()
router.register(r'parcels', ParcelViewSet)
router.register(r'dispatches', DispatchViewSet)

urlpatterns = [
    path('admin/', admin.site.urls),
    
    # Authentication URLs
    path('login/', login_view, name='login'),
    path('logout/', logout_view, name='logout'),
    
    # API URLs
    path('api/', include(router.urls)),
    
    # Web URLs
    path('', login_required(DashboardView.as_view()), name='dashboard'),
    path('parcels/', login_required(ParcelListView.as_view()), name='parcel_list'),
    path('parcels/<uuid:parcel_id>/', login_required(ParcelDetailView.as_view()), name='parcel_detail'),
    path('parcels/<uuid:parcel_id>/consignment-note/', login_required(ConsignmentNoteView.as_view()), name='consignment_note'),
    path('dispatches/', login_required(DispatchListView.as_view()), name='dispatch_list'),
    path('dispatches/create/', login_required(CreateDispatchView.as_view()), name='create_dispatch'),
    path('dispatches/<uuid:dispatch_id>/', login_required(DispatchDetailView.as_view()), name='dispatch_detail'),
    path('dispatches/<uuid:dispatch_id>/note/', login_required(DispatchNoteView.as_view()), name='dispatch_note'),
]

if settings.DEBUG:
    urlpatterns += static(settings.MEDIA_URL, document_root=settings.MEDIA_ROOT)
    urlpatterns += static(settings.STATIC_URL, document_root=settings.STATIC_ROOT)
