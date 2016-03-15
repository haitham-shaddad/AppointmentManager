using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManager.Models
{
    public class ValueObject<T>
    {
        T Value { get; set; }
    }
}
