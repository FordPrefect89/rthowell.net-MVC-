using System.Web;
using System.Web.Mvc;

namespace rthowell.net__ASP_MVC_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
