using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace PermissionLibrary.Filter
{
    public class CanEditPermission: ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        { 
            
        }
    }
}