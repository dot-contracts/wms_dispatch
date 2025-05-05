using System;
using System.Collections.ObjectModel;
using wms_android.shared.Interfaces;
using wms_android.shared.Models;
using wms_android.ViewModels;

namespace wms_android.Utils
{
    /// <summary>
    /// Adapter methods for ReceiptViewModel to handle different constructor patterns
    /// </summary>
    public static class ReceiptViewModelAdapter
    {
        /// <summary>
        /// Creates a ReceiptViewModel for a single parcel
        /// </summary>
        public static ReceiptViewModel CreateForSingleParcel(IParcelService parcelService, Parcel parcel)
        {
            // Calculate total amount if not set
            decimal totalAmount;
            if (parcel.TotalAmount > 0)
            {
                totalAmount = parcel.TotalAmount;
            }
            else if (parcel.Rate != null && parcel.Rate > 0 && parcel.Quantity != null && parcel.Quantity > 0)
            {
                totalAmount = (parcel.Rate ?? 0) * (parcel.Quantity ?? 0);
                parcel.TotalAmount = totalAmount;
            }
            else
            {
                totalAmount = parcel.Amount ?? 0;
                parcel.TotalAmount = totalAmount;
            }
            
            var viewModel = new ReceiptViewModel(parcelService) 
            { 
                Parcel = parcel,
                WaybillNumber = parcel.WaybillNumber,
                TotalAmount = totalAmount,
                PaymentMethod = parcel.PaymentMethods
            };
            return viewModel;
        }

        /// <summary>
        /// Creates a ReceiptViewModel for multiple parcels with a waybill
        /// </summary>
        public static ReceiptViewModel CreateForMultipleParcels(
            IParcelService parcelService, 
            ObservableCollection<Parcel> parcels, 
            string waybillNumber)
        {
            return new ReceiptViewModel(
                parcelService,
                parcels,
                waybillNumber);
        }
    }
} 