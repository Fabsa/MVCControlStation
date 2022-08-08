using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCControlStation.Models
{
    public class Station  //seria Department
    {
        public int Id { get; set; }
        public int NameStation { get; set; }
        public ICollection<TestTecnian> TestTecnians { get; set; } = new List<TestTecnian> ( );

        public Station() { }

        public Station( int id, int nameStation )
        {
            Id = id;
            NameStation = nameStation;
        }
    }
}


//cadastra as estações e adiciona os tecnicos que atuan nas falhas e mostra totalde falhas