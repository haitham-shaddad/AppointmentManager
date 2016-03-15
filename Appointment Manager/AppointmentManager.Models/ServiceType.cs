using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManager.Models
{
    public class ServiceType : BusinessEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Service> Services { get; set; }

        public virtual ICollection<ServiceTypeAttribute> ServiceTypeAttributes { get; set; }

        public virtual ICollection<ServiceProvider> ServiceProviders { get; set; }

    }
}
