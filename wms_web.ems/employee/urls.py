from django.urls import path
from . import views

urlpatterns = [
    path('', views.home, name='home'),
    path('login/', views.login_view, name='login'),
    path('logout/', views.logout_view, name='logout'),
    path('dashboard/', views.dashboard, name='employee_dashboard'),
    path('employees/', views.employee_list, name='employee_list'),
    path('employees/register/', views.register_employee, name='register_employee'),
    path('employees/<int:employee_id>/edit/', views.edit_employee, name='edit_employee'),
    path('employees/<int:employee_id>/', views.employee_detail, name='employee_detail'),
    path('employees/<int:employee_id>/reset-password/', views.reset_password, name='reset_password'),
    
    # API endpoint for Android app login
    path('api/record-login/', views.record_login, name='record_login'),
] 