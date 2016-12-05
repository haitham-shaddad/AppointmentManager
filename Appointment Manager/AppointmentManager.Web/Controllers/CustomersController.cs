using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppointmentManager.Web.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        [Route(template:"Customers/BrowseServices")]
        public ActionResult Services()
        {

            return View();
        }

        public ActionResult Providers()
        {
            return View();
        }

        public ActionResult ProviderDetails()
        {
            return View();
        }

        public ActionResult BookAppointment()
        {
            return View();
        }

        public ActionResult Calendar()
        {
            return View();
        }
    }
}