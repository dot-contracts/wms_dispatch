using System;
using System.Collections.Generic;

namespace wms_android.shared.Models
{
    public class Dispatch
    {
        public Guid Id { get; set; }
        public string SourceBranch { get; set; }
        public string VehicleNumber { get; set; }
        public string Driver { get; set; }
        public List<Guid> ParcelIds { get; set; }
        public DateTime DispatchTime { get; set; }
        public string Status { get; set; }
        public List<Parcel> Parcels { get; set; }
    }
} 