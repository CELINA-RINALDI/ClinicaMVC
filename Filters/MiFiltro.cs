using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCClinica.Filters
{
    public class MiFiltro: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var controller = filterContext.RouteData.Values["controller"];
            var action = filterContext.RouteData.Values["action"];
            Debug.WriteLine("Controller: " + controller + " action: " + action + " paso por OnActionExecuting");

        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            var controller = filterContext.RouteData.Values["controller"];
            var action = filterContext.RouteData.Values["action"];
            Debug.WriteLine("Controller: " + controller + " action: " + action + " paso por OnActionExecuted");
        }
    }
}