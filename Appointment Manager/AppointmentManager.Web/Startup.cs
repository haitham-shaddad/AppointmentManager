using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppointmentManager.Web.Startup))]
namespace AppointmentManager.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
