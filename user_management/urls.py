from django.urls import path
from . import views

app_name = 'user_management'

urlpatterns = [
    path('', views.user_list, name='user_list'),
    path('register/', views.register_user, name='register_user'),
    path('update/<int:user_id>/', views.update_user, name='update_user'),
    path('change-password/<int:user_id>/', views.change_password, name='change_password'),
] 