from django.contrib import admin
from django.urls import reverse
from django.utils.html import format_html

class UserManagementAdmin(admin.ModelAdmin):
    def get_urls(self):
        from django.urls import path
        urls = super().get_urls()
        custom_urls = [
            path('user-management/', self.admin_site.admin_view(self.user_management_view), name='user-management'),
        ]
        return custom_urls + urls

    def user_management_view(self, request):
        from django.shortcuts import redirect
        return redirect('user_management:user_list')

    def changelist_view(self, request, extra_context=None):
        extra_context = extra_context or {}
        extra_context['user_management_url'] = reverse('user_management:user_list')
        return super().changelist_view(request, extra_context=extra_context)

# Register a dummy model to add the user management link to admin
from django.contrib.auth.models import User
admin.site.unregister(User)  # Unregister the default User admin
admin.site.register(User, UserManagementAdmin)  # Register with our custom admin
