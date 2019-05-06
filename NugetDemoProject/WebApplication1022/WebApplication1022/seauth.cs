using Authorization_Module_Framework_MVC.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1022
{
    public class seauth:PermissionAuthorize
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            Id = 2;
            base.OnAuthorization(filterContext);
        }
    }
}