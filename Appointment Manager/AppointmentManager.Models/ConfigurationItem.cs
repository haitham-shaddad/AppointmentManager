using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManager.Models
{
    public class ConfigurationItem : ValueObject<string>
    {
        public string Value { get; set; }

        public string Key { get; set; }
    }
}
