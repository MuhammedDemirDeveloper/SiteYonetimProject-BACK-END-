using Microsoft.AspNetCore.Mvc;

namespace SiteYonetimDatabase.Controllers
{
    public class illerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
