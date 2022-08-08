using System;
using MVCControlStation.Models.enums;

namespace MVCControlStation.Models
{
    public class FaultControl
    {
        public int Id { get; set; }
        public int Week { get; set; }
        public DateTime StopDate { get; set; }
        public DateTime ActivEnginer { get; set; }
        public DateTime StartService { get; set; }
        public string TipeFault { get; set; }
        public FaultStatus faultStatus { get; set; }
        public TestTecnian TestTecnian { get; set; }

        public FaultControl()
        {
        }

        public FaultControl( int id, int week, DateTime stopDate, DateTime activEnginer, DateTime startService, string tipeFault, FaultStatus faultStatus, TestTecnian testTecnian )
        {
            Id = id;
            Week = week;
            StopDate = stopDate;
            ActivEnginer = activEnginer;
            StartService = startService;
            TipeFault = tipeFault;
            this.faultStatus = faultStatus;
            TestTecnian = testTecnian;
        }
    }
}
//Registraas falhas e atuações 1° FirstAtque e engenharia (esta classe seria salesRecord)