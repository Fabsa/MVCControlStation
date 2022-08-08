using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCControlStation.Models
{
    public class Shift
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Shift() { }

        public Shift( int id, string name )
        {
            Id = id;
            Name = name;
        }
    }
}
