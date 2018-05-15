using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CoreFirstPrimer.Models.NHL;

namespace CoreFirstPrimer.Data
{
    public class NhlContext:DbContext
    {
        public NhlContext():base("DefaultConnection")
        {}

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}