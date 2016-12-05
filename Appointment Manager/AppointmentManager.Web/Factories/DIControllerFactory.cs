using AppointmentManager.Models;
using AppointmentManager.Repository.EntityFramework;
using AppointmentManager.Services;
using AppointmentManager.Web.App_Start;
using AppointmentManager.Web.Areas.Admin.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AppointmentManager.Web.Factories
{
    public class DIControllerFactory : DefaultControllerFactory
    {
        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            if (controllerName.ToLower() == "servicetypes")
            {
                return StructureMapConfig.Container.GetInstance<ServiceTypesController>();
            }

            return base.CreateController(requestContext, controllerName);
        }
    }
}