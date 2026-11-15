using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Passengers
    {
        //public Passengers()
        //{
        //    Bookings = new HashSet<Bookings>();
        //}

        public int PassengerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PassportNumber { get; set; }
        public bool Status { get; set; }
        public int PassengerCode { get; set; }

        //public virtual ICollection<Bookings> Bookings { get; set; }
    }
}
