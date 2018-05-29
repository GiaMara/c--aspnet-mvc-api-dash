using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LADOTDash_API.Models
{
    public class LADOTDashDB : DbContext
    {
        public LADOTDashDB(): base("name=DefaultConnection")
        {

        }
        public DbSet<BusStop> BusStops { get; set; }
    }
}