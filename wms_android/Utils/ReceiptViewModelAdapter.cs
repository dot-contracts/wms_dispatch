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
            var viewModel = new ReceiptViewModel(parcelService) { Parcel = parcel };
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
            decimal totalAmount = 0;
            foreach (var parcel in parcels)
            {
                totalAmount += parcel.Amount;
            }

            var paymentMethods = new ObservableCollection<string> { "Cash", "Mobile Money", "Credit Card" };
            
            return new ReceiptViewModel(
                parcelService,
                parcels,
                waybillNumber,
                totalAmount,
                paymentMethods);
        }
    }
} 