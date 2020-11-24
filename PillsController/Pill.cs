using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillsController
{
    class Pill
    {
        private int id { get; set; }

        private string name;
        private DateTime startDate, endDate;


        public Pill()
        {

        }

        public Pill(string name, DateTime startDate, DateTime endDate)
        {
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }
}
