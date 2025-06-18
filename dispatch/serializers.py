from rest_framework import serializers
from datetime import datetime
from decimal import Decimal

class ParcelSerializer(serializers.Serializer):
    id = serializers.UUIDField()
    created_at = serializers.DateTimeField()
    waybill_number = serializers.CharField(allow_null=True, required=False)
    qr_code = serializers.CharField(allow_null=True, required=False)
    dispatched_at = serializers.DateTimeField(allow_null=True, required=False)
    dispatch_tracking_code = serializers.CharField(allow_null=True, required=False)
    sender = serializers.CharField()
    sender_telephone = serializers.CharField()
    receiver = serializers.CharField()
    receiver_telephone = serializers.CharField()
    destination = serializers.CharField()
    quantity = serializers.IntegerField()
    description = serializers.CharField()
    amount = serializers.DecimalField(max_digits=10, decimal_places=2)
    rate = serializers.DecimalField(max_digits=10, decimal_places=2)
    payment_methods = serializers.CharField()
    total_amount = serializers.DecimalField(max_digits=10, decimal_places=2)
    total_rate = serializers.DecimalField(max_digits=10, decimal_places=2)
    status = serializers.IntegerField()

class DispatchSerializer(serializers.Serializer):
    id = serializers.UUIDField()
    dispatch_date = serializers.DateTimeField()
    destination = serializers.CharField()
    dispatch_code = serializers.CharField()
    vehicle_registration = serializers.CharField(allow_null=True, required=False)
    driver_name = serializers.CharField(allow_null=True, required=False)
    total_parcels = serializers.IntegerField()
    total_amount = serializers.DecimalField(max_digits=12, decimal_places=2)
    status = serializers.IntegerField()
    parcels = ParcelSerializer(many=True, required=False)

class DispatchCreateSerializer(serializers.Serializer):
    destination = serializers.CharField()
    vehicle_registration = serializers.CharField(allow_null=True, required=False)
    driver_name = serializers.CharField(allow_null=True, required=False)
    parcel_ids = serializers.ListField(
        child=serializers.UUIDField(),
        min_length=1
    ) 