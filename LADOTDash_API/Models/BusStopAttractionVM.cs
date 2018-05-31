using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LADOTDash_API.Models
{
    public class BusStopAttractionVM
    {
        public IEnumerable<BusStop> Stops { get; set; }
        public IEnumerable<Attraction> StopAttractions { get; set; }
    }
}