using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManager.Models
{
    public abstract class BusinessEntity
    {
        public int ID { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastModificationDate { get; set; }

        public string CreatedBy { get; set; }

        public string LastModifiedBy { get; set; }
    }
}
