using System.Web;
using System.Web.Mvc;

namespace Ch_4._1._12_TryCatchExample1_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
