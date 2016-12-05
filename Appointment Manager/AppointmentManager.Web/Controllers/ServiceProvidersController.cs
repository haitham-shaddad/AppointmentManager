using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppointmentManager.Web.Controllers
{
    public class ServiceProvidersController : Controller
    {
        // GET: ServiceProviders
        public ActionResult Calendar()
        {
            return View();
        }

        public ActionResult AppointmentDetails()
        {
            return View();
        }

        public ActionResult ManageServices()
        {
            return View();
        }

        public ActionResult AvailableTime()
        {
            return View();
        }
    }
}