using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCControlStation.Models;

namespace MVCControlStation.Models
{
    public class MVCControlStationContext : DbContext
    {
        public MVCControlStationContext (DbContextOptions<MVCControlStationContext> options): base(options)
        {
        }

        public DbSet<MVCControlStation.Models.Station> Station { get; set; }

        public DbSet<MVCControlStation.Models.TestTecnian> TestTecnian { get; set; }

        public DbSet<MVCControlStation.Models.FaultControl> FaultControl { get; set; }

     


    }
}
