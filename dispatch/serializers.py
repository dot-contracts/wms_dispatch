from rest_framework import serializers
from .models import Parcel, Dispatch, DispatchParcel

class ParcelSerializer(serializers.ModelSerializer):
    status_display = serializers.CharField(source='get_status_display', read_only=True)
    
    class Meta:
        model = Parcel
        fields = '__all__'

class DispatchParcelSerializer(serializers.ModelSerializer):
    parcel = ParcelSerializer(read_only=True)
    
    class Meta:
        model = DispatchParcel
        fields = ['id', 'parcel']

class DispatchSerializer(serializers.ModelSerializer):
    parcels = DispatchParcelSerializer(many=True, read_only=True)
    status_display = serializers.CharField(source='get_status_display', read_only=True)
    
    class Meta:
        model = Dispatch
        fields = '__all__'

class DispatchCreateSerializer(serializers.ModelSerializer):
    parcel_ids = serializers.ListField(
        child=serializers.UUIDField(),
        write_only=True,
        required=False
    )
    
    class Meta:
        model = Dispatch
        fields = ['id', 'destination', 'dispatch_code', 'status', 'parcel_ids']
    
    def create(self, validated_data):
        parcel_ids = validated_data.pop('parcel_ids', [])
        dispatch = Dispatch.objects.create(**validated_data)
        
        total_parcels = 0
        total_amount = 0
        
        for parcel_id in parcel_ids:
            try:
                parcel = Parcel.objects.get(id=parcel_id)
                DispatchParcel.objects.create(dispatch=dispatch, parcel=parcel)
                
                # Update parcel status and dispatch tracking info
                parcel.status = 2  # IN_TRANSIT
                parcel.dispatch_tracking_code = dispatch.dispatch_code
                parcel.save()
                
                # Update totals
                total_parcels += 1
                total_amount += parcel.total_amount
            except Parcel.DoesNotExist:
                pass
        
        # Update dispatch totals
        dispatch.total_parcels = total_parcels
        dispatch.total_amount = total_amount
        dispatch.save()
        
        return dispatch 