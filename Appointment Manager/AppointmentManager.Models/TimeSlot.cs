using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManager.Models
{
    public class TimeSlot : ValueObject<TimePeriod>
    {
        public int ID { get; set; }

        public TimePeriod Value
        {
            get; set;
        }
    }

    public class TimePeriod
    {
        public DateTime StartTime { get; set; }

        public int DurationInMinutes { get; set; }
    }

}
