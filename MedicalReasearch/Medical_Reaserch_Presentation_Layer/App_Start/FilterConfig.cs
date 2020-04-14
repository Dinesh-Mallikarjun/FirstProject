using System.Web;
using System.Web.Mvc;

namespace Medical_Reaserch_Presentation_Layer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
