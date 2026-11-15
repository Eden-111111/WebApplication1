using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Airlines
    {
    //    public Airlines()
    //    {
    //        Aircraft = new HashSet<Aircraft>();
    //    }

        public int AirlineId { get; set; }
        public string AirlineName { get; set; }
        public string Country { get; set; }
        public bool Status { get; set; }

       // public virtual ICollection<Aircraft> Aircraft { get; set; }
    }
}
