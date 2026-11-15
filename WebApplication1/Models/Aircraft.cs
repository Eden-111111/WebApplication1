using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Aircraft
    {
        //public Aircraft()
        //{
        //    Flights = new HashSet<Flights>();
        //}

        public int AircraftId { get; set; }
        public int AirlineId { get; set; }
        public string Model { get; set; }
        public int SeatCapacity { get; set; }
        public bool Status { get; set; }

        //public virtual Airlines Airline { get; set; }
        //public virtual ICollection<Flights> Flights { get; set; }
    }
}
