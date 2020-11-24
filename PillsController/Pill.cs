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

        private string name;
        private DateTime startDate, endDate;
        private int timesPerDay;

        public string Name
        {
            get { return name;}
            set { name = value;}
        }
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        public int TimesPerDay
        {
            get { return timesPerDay; }
            set { timesPerDay = value; }
        }


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
