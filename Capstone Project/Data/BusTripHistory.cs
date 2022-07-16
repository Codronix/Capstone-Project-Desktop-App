using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project.Data
{
    public class BusTripHistory
    {
        public string Date { get; set; }
        public string BusNumber { get; set; }
        public string BusRoute { get; set; }
        public string BusTripRound { get; set; }
        public string BusDriverID_1 { get; set; }
        public string BusDriverName_1 { get; set; }
        public string BusDriverID_2 { get; set; }
        public string BusDriverName_2 { get; set; }
        public string BusConductorID { get; set; }
        public string BusConductorName { get; set; }
    }
}
