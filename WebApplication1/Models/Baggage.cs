using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Baggage
    {
        public int BaggageId { get; set; }
        public int BookingId { get; set; }
        public string BaggageTag { get; set; }
        public double Weight { get; set; }
        public string BaggageType { get; set; }
        public string Status { get; set; }
        public bool Status1 { get; set; }

        //public virtual Bookings Booking { get; set; }
    }
}
