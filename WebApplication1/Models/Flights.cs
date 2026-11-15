using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Flights
    {
        //public Flights()
        //{
        //    Bookings = new HashSet<Bookings>();
        //}

        public int FlightId { get; set; }
        public int AircraftId { get; set; }
        public int DepartureAirportId { get; set; }
        public int ArrivalAirportId { get; set; }
        public string DepartureDate { get; set; }
        public string Status { get; set; }
        public string DepartureTime { get; set; }
        public bool Status1 { get; set; }

        //public virtual Aircraft Aircraft { get; set; }
        //public virtual Airports ArrivalAirport { get; set; }
        //public virtual Airports DepartureAirport { get; set; }
        //public virtual ICollection<Bookings> Bookings { get; set; }
    }
}
