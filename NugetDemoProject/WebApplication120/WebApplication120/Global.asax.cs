using Authorization_Module_Framework_API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Http.Filters;
using System.Web.Routing;

namespace WebApplication120
{
    public class WebApiApplication : System.Web.HttpApplication
    { 
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configuration.Services.Replace(typeof(IFilterProvider), new ChangeFilter(typeof(AuthF)));
        }
    }
}
