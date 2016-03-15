using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManager.Models
{
    public class Appointment : BusinessEntity
    {
        public int ServiceProviderID { get; set; }

        public int CustomerID { get; set; }

        public int CustomerProfileId { get; set; }

        public int AppointmentStatusId { get; set; }

        public int TimeSlotId { get; set; }

        public DateTime AppointmentTime { get; set; }

        public int DurationInMinutes { get; set; }

        public bool IsPaidByProvider { get; set; }

        public AppointmentStatus AppointmentStatus { get; set; }

        public Customer Customer { get; set; }

        public ICollection<Service> Services { get; set; }

        public ServiceProvider ServiceProvider { get; set; }

        public CustomerProfile CustomerProfile { get; set; }

        public TimeSlot TimeSlot { get; set; }

        public ServiceProviderReview CustomerReview { get; set; }
    }
}
