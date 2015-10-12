using System.Web;
using System.Web.Mvc;

namespace MvcSiteMap_SimpleInjector3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}