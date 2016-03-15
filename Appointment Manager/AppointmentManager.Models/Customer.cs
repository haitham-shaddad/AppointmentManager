using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManager.Models
{
    public class Customer : User
    {
        public string Address { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }

        public virtual ICollection<CustomerProfile> Profiles { get; set; }

    }
}
