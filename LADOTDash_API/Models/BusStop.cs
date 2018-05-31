using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LADOTDash_API.Models
{
    public class BusStop
    {
        public int BusStopID { get; set; }
        public string StopLocation { get; set; }
        public ICollection<Attraction> Attractions { get; set; }
    }
}