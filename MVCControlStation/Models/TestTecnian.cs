using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCControlStation.Models;

namespace MVCControlStation.Models
{
    public class TestTecnian
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Station Station { get; set; }
        public ICollection<FaultControl> Faults { get; set; } = new List<FaultControl> ( );

        public TestTecnian()
        {
        }

        public TestTecnian( int id, string name, Station station, ICollection<FaultControl> faults )
        {
            Id = id;
            Name = name;
            Station = station;
            Faults = faults;
        }

        public void AddFaults(FaultControl fc )
        {
            Faults.Add ( fc );
            
        }
        public void RemoveFaults(FaultControl fc)
        {
            Faults.Remove ( fc );
        }

        public DateTime FulDates(DateTime Initial,DateTime final)
        {
            return Faults.Where ( fc => fc.StopDate >= Initial && fc.StartService <= final ).( fc => fc.StopDate);
        }



    } 

}
//representa Seller