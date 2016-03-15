using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManager.Models
{
    public class CustomerProfileAttribute : BusinessEntity
    {
        public int CustomerProfileID { get; set; }

        public int ServiceTypeAttributeID { get; set; }

        public string AttributeValue { get; set; }

        public CustomerProfile CustomerProfile { get; set; }

        public ServiceTypeAttribute ServiceTypeAttribute { get; set; }
    }
}
