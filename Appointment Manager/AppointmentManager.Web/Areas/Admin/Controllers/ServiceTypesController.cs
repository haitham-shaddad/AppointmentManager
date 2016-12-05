using AppointmentManager.Models;
using AppointmentManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppointmentManager.Web.Areas.Admin.Controllers
{
    public class ServiceTypesController : Controller
    {
        IService<ServiceType, int> _serviceTypeService;

        public ServiceTypesController(IService<ServiceType, int> serviceTypeService)
        {
            this._serviceTypeService = serviceTypeService;
        }

        // GET: Admin/ServiceTypes
        public ActionResult Index()
        {
            return View(_serviceTypeService.GetAll());
        }
    }
}