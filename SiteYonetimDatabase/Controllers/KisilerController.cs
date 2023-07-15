using Microsoft.AspNetCore.Mvc;

namespace SiteYonetimDatabase.Controllers
{
    public class KisilerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
