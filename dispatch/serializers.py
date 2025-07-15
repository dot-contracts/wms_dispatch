from rest_framework import serializers
from datetime import datetime
from decimal import Decimal

class ParcelSerializer(serializers.Serializer):
    id = serializers.UUIDField()
    createdAt = serializers.DateTimeField()
    waybillNumber = serializers.CharField(max_length=100)
    qrCode = serializers.CharField(max_length=100)
    dispatchedAt = serializers.DateTimeField(allow_null=True, required=False)
    dispatchTrackingCode = serializers.CharField(max_length=100, allow_null=True, required=False)
    sender = serializers.CharField(max_length=200)
    senderTelephone = serializers.CharField(max_length=20)
    receiver = serializers.CharField(max_length=200)
    receiverTelephone = serializers.CharField(max_length=20)
    destination = serializers.CharField(max_length=100)
    quantity = serializers.IntegerField()
    description = serializers.CharField(max_length=500)
    amount = serializers.DecimalField(max_digits=10, decimal_places=2)
    rate = serializers.DecimalField(max_digits=10, decimal_places=2)
    paymentMethods = serializers.CharField(max_length=100)
    totalAmount = serializers.DecimalField(max_digits=10, decimal_places=2)
    totalRate = serializers.DecimalField(max_digits=10, decimal_places=2)
    status = serializers.IntegerField()
    createdBy = serializers.CharField(max_length=100, required=False)


class DispatchSerializer(serializers.Serializer):
    id = serializers.UUIDField(required=False)
    dispatch_code = serializers.CharField(max_length=100, required=False)
    driver_name = serializers.CharField(max_length=100)
    driver_license_plate = serializers.CharField(max_length=20)
    total_parcels = serializers.IntegerField()
    total_amount = serializers.DecimalField(max_digits=12, decimal_places=2)
    dispatched_at = serializers.DateTimeField(required=False, allow_null=True)
    parcels = ParcelSerializer(many=True, required=False)

class DispatchNoteSerializer(serializers.Serializer):
    parcel_ids = serializers.ListField(
        child=serializers.UUIDField()
    )
    driver_name = serializers.CharField(max_length=100)
    driver_license_plate = serializers.CharField(max_length=20) 