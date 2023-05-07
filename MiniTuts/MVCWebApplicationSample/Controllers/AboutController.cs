using Microsoft.AspNetCore.Mvc;

namespace MVCWebApplicationSample.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
