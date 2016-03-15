using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManager.Models
{
        public class ServiceProvider : User
        {
            public string Title { get; set; }

            public string StreetAddress1 { get; set; }

            public string StreetAddress2 { get; set; }

            public string City { get; set; }

            public string State { get; set; }

            public string CountryID { get; set; }

            public string ZipCode { get; set; }

            public string BusinessTelephoneNumber { get; set; }

            public string WebSite { get; set; }

            public string TaxIdentificationNumber { get; set; }

            public string LicenseNumber { get; set; }

            public bool IsAvailableSaturday { get; set; }

            public bool IsAvailableSunday { get; set; }

            public bool IsAvailableMonday { get; set; }

            public bool IsAvailableTuesday { get; set; }

            public bool IsAvailableWednesday { get; set; }

            public bool IsAvailableThursday { get; set; }

            public bool IsAvailableFriday { get; set; }

            public virtual Country Country { get; set; }

            public virtual ICollection<Appointment> Appointments { get; set; }

            public virtual ICollection<ServiceType> ServiceTypes { get; set; }

            public virtual ICollection<TimeSlot> Availability { get; set; }

            public virtual ICollection<ServiceProviderReview> Reviews { get; set; }
        }
}
