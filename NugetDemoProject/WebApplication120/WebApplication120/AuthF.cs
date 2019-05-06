using Authorization_Module_Framework_API.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;

namespace WebApplication120
{
    public class AuthF:PermissionAuthorize
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            Id = 2;
            base.OnAuthorization(actionContext); 
        }
    }
}