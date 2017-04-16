using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using UnityConfig = Jusan.App_Start.UnityConfig;

namespace Jusan
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //load mvc container and use it as dynamic mvc container
            var mvcContainer = UnityConfig.GetConfiguredContainer();
            DynamicMVC.Shared.Container.EagerLoadedContainer = mvcContainer;
            DynamicMVC.Shared.UnityConfig.RegisterTypes(mvcContainer);

           
        }
    }
}
