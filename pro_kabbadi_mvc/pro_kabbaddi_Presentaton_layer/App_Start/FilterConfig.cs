using System.Web;
using System.Web.Mvc;

namespace pro_kabbaddi_Presentaton_layer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
