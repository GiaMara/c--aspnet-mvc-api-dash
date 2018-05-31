using LADOTDash_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LADOTDash_API.Controllers
{
    public class BusStopAttractionController : ApiController
    {

        LADOTDashDB _db = new LADOTDashDB();



        public IEnumerable<Attraction> GetAllAttractions()
        {
            var attractions = _db.Attractions.ToList();
            return attractions;
        }

        public IHttpActionResult GetAttraction(int id)
        {
            var attractions = _db.Attractions.ToList();
            var attraction = attractions.FirstOrDefault((p) => p.AttractionID == id);
            if (attraction == null)
            {
                return NotFound();
            }
            return Ok(attraction);
        }
    }
}
