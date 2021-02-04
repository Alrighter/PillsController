using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillsController
{
    class calendarHiden
    {
        private string _name;
        private byte _timesPerDay;
        private byte _duration;

        public string Name {get{return _name;}set{_name = Name;}}
        public byte TimesPerDay { get { return _timesPerDay; } set { _timesPerDay = TimesPerDay; } }
        public byte Duration { get { return _duration; } set { _duration = Duration; } }

        private void AlarmTime()
        {
            var Date01 = new DateTime();
            var Date02 = new DateTime();
            var Date03 = new DateTime();
            DateTime CurrentTime = DateTime.Now;
            switch (TimesPerDay)
            {
                case 1:
                    Date01 = new DateTime(2020, 11, 9, 12, 0, 0);
                    break;
                case 2:
                    Date01 = new DateTime(2020, 11, 9, 12, 0, 0);
                    Date02 = new DateTime(2020, 11, 9, 20, 0, 0);
                    break;
                case 3:
                    Date01 = new DateTime(2020, 11, 9, 10, 0, 0);
                    Date02 = new DateTime(2020, 11, 9, 15, 0, 0);
                    Date03 = new DateTime(2020, 11, 9, 20, 0, 0);
                    break;
            }

            if (CurrentTime == Date01)
            {
                
            }
            else if (CurrentTime == Date02)
            {
                
            }
            else if (CurrentTime == Date03)
            {

            }
            
        }
    }
}
