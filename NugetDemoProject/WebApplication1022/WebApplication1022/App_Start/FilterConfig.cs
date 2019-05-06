using Authorization_Module_Framework_MVC.Resolver;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1022
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            FilterProviders.Providers.Clear();
          //  FilterProviders.Providers.Add(new FilterChange(typeof(seauth)));
        }
    }
}
