using System.Web;
using System.Web.Mvc;

namespace Astorino.Giacomo._5h.WebAccessDatabase
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
