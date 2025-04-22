from django.contrib import admin
from .models import Employee, Role, Branch, LoginActivity

class EmployeeAdmin(admin.ModelAdmin):
    list_display = ('employee_id', 'full_name', 'phone_number', 'id_number', 'is_active')
    list_filter = ('is_active', 'roles', 'branches')
    search_fields = ('employee_id', 'user__first_name', 'user__last_name', 'phone_number', 'id_number')
    filter_horizontal = ('roles', 'branches')

class RoleAdmin(admin.ModelAdmin):
    list_display = ('name', 'description')

class BranchAdmin(admin.ModelAdmin):
    list_display = ('name', 'description')

class LoginActivityAdmin(admin.ModelAdmin):
    list_display = ('employee', 'login_date', 'login_time', 'device_name')
    list_filter = ('login_date', 'employee__branches')
    search_fields = ('employee__user__first_name', 'employee__user__last_name', 'employee__employee_id')
    date_hierarchy = 'login_date'

admin.site.register(Employee, EmployeeAdmin)
admin.site.register(Role, RoleAdmin)
admin.site.register(Branch, BranchAdmin)
admin.site.register(LoginActivity, LoginActivityAdmin)
