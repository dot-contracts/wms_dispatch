from django.contrib import admin
from .models import Parcel, Dispatch, DispatchParcel

class ParcelAdmin(admin.ModelAdmin):
    list_display = ('waybill_number', 'sender', 'receiver', 'destination', 'total_amount', 'status')
    list_filter = ('status', 'destination')
    search_fields = ('waybill_number', 'sender', 'receiver', 'receiver_telephone')
    readonly_fields = ('id', 'created_at')

class DispatchParcelInline(admin.TabularInline):
    model = DispatchParcel
    extra = 1

class DispatchAdmin(admin.ModelAdmin):
    list_display = ('dispatch_code', 'destination', 'dispatch_date', 'total_parcels', 'total_amount', 'status')
    list_filter = ('status', 'destination')
    search_fields = ('dispatch_code', 'destination')
    inlines = [DispatchParcelInline]
    readonly_fields = ('id', 'dispatch_date')

admin.site.register(Parcel, ParcelAdmin)
admin.site.register(Dispatch, DispatchAdmin)
