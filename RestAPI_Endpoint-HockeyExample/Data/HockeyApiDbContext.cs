using Microsoft.EntityFrameworkCore;
using RestAPI_Endpoint_HockeyExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_Endpoint_HockeyExample.Data
{
    public class HockeyApiDbContext : DbContext
    {
        public HockeyApiDbContext(DbContextOptions<HockeyApiDbContext> opt) : base(opt)
        {

        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}
