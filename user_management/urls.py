from django.urls import path
from . import views

app_name = 'user_management'

urlpatterns = [
    # Main dashboard
    path('', views.user_management_dashboard, name='dashboard'),
    
    # User management
    path('list/', views.user_list, name='user_list'),
    path('register/', views.register_user, name='register_user'),
    path('update/<int:user_id>/', views.update_user, name='update_user'),
    path('change-password/<int:user_id>/', views.change_password, name='change_password'),
    path('toggle-status/<int:user_id>/', views.toggle_user_status, name='toggle_user_status'),
    
    # Live users and sessions
    path('live-users/', views.live_users_view, name='live_users'),
    path('sessions/end/<uuid:session_id>/', views.end_user_session, name='end_session'),
    
    # Device management
    path('devices/', views.devices_view, name='devices'),
    path('devices/<str:serial_number>/', views.device_detail, name='device_detail'),
    
    # Role management
    path('roles/', views.roles_view, name='roles'),
    path('roles/create/', views.create_role, name='create_role'),
    
    # Activity logs
    path('activities/', views.activity_logs, name='activity_logs'),
] 