using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LADOTDash_API.Models
{
    public class Attraction
    {
        [Key]
        public int AttractionID { get; set; }

        public int BusStopID { get; set; }
        public string ImgSrc { get; set; }
        public string ImgDescription { get; set; }
    }
}