using Microsoft.AspNetCore.Mvc;

namespace SiteYonetimDatabase.Controllers
{
    public class SitelerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
