using System.Web;
using System.Web.Mvc;

namespace SOAnswer_44879268
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
