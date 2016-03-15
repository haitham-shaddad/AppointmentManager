using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManager.Models
{
    public class ServiceTypeAttribute : BusinessEntity
    {
        public int ServiceTypeID { get; set; }

        public string AttributeName { get; set; }

        public string LookupValues { get; set; }

        public int ServiceAttributeTypeID { get; set; }

        public AttributeType AttributeType { get; set; }

        public ServiceType ServiceType { get; set; }
    }
}
