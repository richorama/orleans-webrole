using Microsoft.WindowsAzure.ServiceRuntime;
using Orleans.Host;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            if (RoleEnvironment.IsAvailable)
            {
                // running in Azure
                OrleansAzureClient.Initialize(Server.MapPath(@"~/AzureConfiguration.xml"));
            }
            else
            {
                // not running in Azure
                Orleans.OrleansClient.Initialize(Server.MapPath(@"~/LocalConfiguration.xml"));
            }
        }
    }
}
