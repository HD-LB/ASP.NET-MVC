using System.Web;
using System.Web.Mvc;
using ViewRazorDemos.ActionFilters;

namespace ViewRazorDemos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LoggingFilterAttribute());
        }
    }
}
