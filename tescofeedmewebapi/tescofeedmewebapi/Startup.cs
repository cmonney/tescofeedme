
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using tescofeedmewebapi;

[assembly : OwinStartup(typeof(Startup))]
namespace tescofeedmewebapi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
             var configuration = new HttpConfiguration();

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            WebApiConfig.Register(configuration);

            app.UseWebApi(configuration);
            app.UseCors(CorsOptions.AllowAll);

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}