using System;
namespace Project_01.Models
{
    public class Event
    {
        public Event()
        {
        }
        DateTime lastRegisterDay;

        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime EventTime { get; set; }
        public Categories Category { get; set; }
        public string Details { get; set; }
        public DateTime LastRegisterDay {
            get
            {
                return lastRegisterDay;
            }
            set
            {
                if(value < EventTime)
                {
                    lastRegisterDay = value;
                }
            }
        }


    }
}

