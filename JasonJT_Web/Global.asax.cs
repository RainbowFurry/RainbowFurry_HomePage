using JasonJT_Web.Database;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace JasonJT_Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Create MongoDB Connection
            var mongoManager = new MongoDBManager();

        }
    }
}
