using PermissionImplement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace PermissionLibrary.Filter
{
    public class CanEditPermission : PermissionActionFilterBase
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var calc = new PermissionCalculator("500");
            if (!calc.ValidatePermission())
            {
                throw new Exception();
            }
        }
    }
}