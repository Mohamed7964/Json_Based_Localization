using Microsoft.AspNetCore.Mvc;

namespace Json_Based_Localization.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
