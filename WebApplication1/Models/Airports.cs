using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Airports
    {
        //public Airports()
        //{
        //    FlightsArrivalAirport = new HashSet<Flights>();
        //    FlightsDepartureAirport = new HashSet<Flights>();
        //    Terminals = new HashSet<Terminals>();
        //}

        public int AirportId { get; set; }
        public string AirportName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool Status { get; set; }

        //public virtual ICollection<Flights> FlightsArrivalAirport { get; set; }
        //public virtual ICollection<Flights> FlightsDepartureAirport { get; set; }
        //public virtual ICollection<Terminals> Terminals { get; set; }
    }
}
