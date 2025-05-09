﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace wms_android.shared.Models
{
    public class Parcel
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column(TypeName = "timestamp with time zone")]
        public DateTime CreatedAt { get; set; }
        public string? WaybillNumber { get; set; }
        public string? QRCode { get; set; }

        [Column(TypeName = "timestamp with time zone")]
        public DateTime? DispatchedAt { get; set; }

        public string? DispatchTrackingCode { get; set; }

        // User who created the parcel
        public int? CreatedById { get; set; }
        
        [ForeignKey("CreatedById")]
        public virtual User? CreatedBy { get; set; }

        public string? CreatorLastNameSnapshot { get; set; }

        // New Shipment relationship
        public Guid? ShipmentId { get; set; } 
        [ForeignKey("ShipmentId")]
        public virtual Shipment? Shipment { get; set; }

        // Sender Details
        public string Sender { get; set; }
        public string SenderTelephone { get; set; }

        // Receiver Details
        public string Receiver { get; set; }
        public string ReceiverTelephone { get; set; }
        public string Destination { get; set; }

        // Parcel Description
        public int? Quantity { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Rate { get; set; }
        public string PaymentMethods { get; set; }

        //was a Calculated Properties
        public decimal TotalAmount { get; set; }
        public decimal TotalRate { get; set; }
        // Status
        public ParcelStatus Status { get; set; } = ParcelStatus.Pending;
    }

    public enum ParcelStatus
    {
        Pending,
        Finalized,
        InTransit,
        Delivered,
        Cancelled
    }
}
