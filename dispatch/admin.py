# from django.contrib import admin
# from .models import Branch, UserProfile

# @admin.register(Branch)
# class BranchAdmin(admin.ModelAdmin):
#     list_display = ('name', 'description', 'created_at', 'updated_at')
#     search_fields = ('name',)

# @admin.register(UserProfile)
# class UserProfileAdmin(admin.ModelAdmin):
#     list_display = ('username', 'email', 'get_full_name', 'branch_name', 'is_branch_manager', 'role')
#     search_fields = ('username', 'first_name', 'last_name', 'email')
#     list_filter = ('is_branch_manager', 'branch_name', 'role')

#     def get_full_name(self, obj):
#         return obj.get_full_name()
#     get_full_name.short_description = 'Full Name'
