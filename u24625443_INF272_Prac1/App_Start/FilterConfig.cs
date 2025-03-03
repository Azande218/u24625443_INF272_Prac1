using System.Web;
using System.Web.Mvc;

namespace u24625443_INF272_Prac1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
