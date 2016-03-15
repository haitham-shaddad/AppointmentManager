using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManager.Models
{
    public class ServiceProviderReview : BusinessEntity
    {
        public string ServiceProviderID { get; set; }

        public int Rating { get; set; }

        public int AppointmentId { get; set; }

        public string CustomerId { get; set; }

        public string Comment { get; set; }

        public virtual ServiceProvider ServiceProvider { get; set; }

        public virtual Appointment Appointment { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
