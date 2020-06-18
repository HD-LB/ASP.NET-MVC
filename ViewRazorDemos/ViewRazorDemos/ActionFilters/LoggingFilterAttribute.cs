using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewRazorDemos.ActionFilters
{
    public class LoggingFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            using (StreamWriter writer = new StreamWriter(HttpContext.Current.Server.MapPath("~/App_Data/log.txt"), true))
            {
                writer.Write(filterContext.HttpContext.Request.RawUrl);
            }
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);

            using (StreamWriter writer = new StreamWriter(HttpContext.Current.Server.MapPath("~/App_Data/log.txt"), true))
            {
                writer.Write($"Finished executing {filterContext.HttpContext.Request.RawUrl});
            }
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }
    }
}