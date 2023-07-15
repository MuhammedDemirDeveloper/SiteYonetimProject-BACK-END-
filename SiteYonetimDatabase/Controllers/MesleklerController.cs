using Microsoft.AspNetCore.Mvc;

namespace SiteYonetimDatabase.Controllers
{
    public class MesleklerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
