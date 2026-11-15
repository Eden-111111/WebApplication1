using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Bookings
    {
        //public Bookings()
        //{
        //    Baggage = new HashSet<Baggage>();
        //}

        public int BookingId { get; set; }
        public int PassengerCode { get; set; }
        public int FlightId { get; set; }
        public string BookingDate { get; set; }
        public int SeatId { get; set; }
        public string BookingStatus { get; set; }
        public double TicketPrice { get; set; }
        public bool Status { get; set; }

        //public virtual Flights Flight { get; set; }
        //public virtual Passengers PassengerCodeNavigation { get; set; }
        //public virtual ICollection<Baggage> Baggage { get; set; }
    }
}
