using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Filter
{
    public class ActionFilters : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.HttpContext.Session == null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Auth", action = "Index" }));
            }
            base.OnActionExecuted(context);
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Session == null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Auth", action = "Index" }));
            }
            base.OnActionExecuting(context);
        }
    }
}
