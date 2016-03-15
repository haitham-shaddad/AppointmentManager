using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManager.Models
{
    public class Service : BusinessEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int ServiceTypeID { get; set; }

        public virtual ServiceType ServiceType { get; set; }
    }
}
