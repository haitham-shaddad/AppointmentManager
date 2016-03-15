using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManager.Models
{
    public class CustomerProfile : BusinessEntity
    {
        public string Name { get; set; }

        public string CustomerID { get; set; }

        public int ServiceTypeID { get; set; }

        public ServiceType ServiceType { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ICollection<CustomerProfileAttribute> Attributes { get; set; }
    }
}
