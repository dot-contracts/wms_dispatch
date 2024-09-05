using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wms_android.data.Models
{
    public class Parcel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Use UTC
        public string WaybillNumber { get; set; }
        public string QRCode { get; set; }
        public DateTime? DispatchedAt { get; set; } = DateTime.UtcNow; // Ensure UTC

        public string? DispatchTrackingCode { get; set; }

        // Sender Details
        public string Sender { get; set; }
        public string SenderTelephone { get; set; }

        // Receiver Details
        public string Receiver { get; set; }
        public string ReceiverTelephone { get; set; }
        public string Destination { get; set; }

        // Parcel Description
        public int Quantity { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal Rate { get; set; }
        public string PaymentMethods { get; set; }

        // Calculated Properties
        public decimal TotalAmount => Amount * Quantity;
        public decimal TotalRate => Rate * Quantity;

        // Status
        public ParcelStatus Status { get; set; } = ParcelStatus.Pending;
    }

    public enum ParcelStatus
    {
        Pending,
        InTransit,
        Delivered,
        Cancelled
    }
}
