using System.Web;
using System.Web.Mvc;

namespace ParamountRestaurant_Project_Part3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
