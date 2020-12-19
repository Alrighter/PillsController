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
        private string startDate, endDate;
        private int timesPerDay;

        public string Name
        {
            get { return name;}
            set { name = value;}
        }
        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public string EndDate
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
            this.name = name ;
            this.startDate = startDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            this.endDate = endDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            this.timesPerDay = timesPerDay;
        }
    }
}
