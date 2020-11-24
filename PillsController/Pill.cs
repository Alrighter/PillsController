using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillsController
{
    class Pill
    {
        public int id { get; set; }

        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int timesPerDay { get; set; }


        public Pill()
        {

        }

        public Pill(string name, DateTime startDate, DateTime endDate, int timesPerDay)
        {
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.timesPerDay = timesPerDay;
        }
    }
}
