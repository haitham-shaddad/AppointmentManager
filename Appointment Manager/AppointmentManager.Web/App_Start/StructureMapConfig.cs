using AppointmentManager.Repository;
using AppointmentManager.Repository.EntityFramework;
using AppointmentManager.Services;
using AppointmentManager.Web.Areas.Admin.Controllers;
using StructureMap;
using StructureMap.Graph;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace AppointmentManager.Web.App_Start
{
    public class StructureMapConfig
    {
        public static Container Container;

        public static IContainer Config()
        {
            Container = new Container();


            Container.Configure(c =>
            {
                c.Scan(s =>
                {
                    s.TheCallingAssembly();
                    s.WithDefaultConventions();
                });

                c.For(typeof(IService<,>)).Use(typeof(BaseService<,>));
                c.For(typeof(IRepository<,>)).Use(typeof(EFRepository<,>));
                c.For<ServiceTypesController>();
                c.For<DbContext>().Use<AppointmentManagerContext>();
            });

            return Container;
        }
    }
}