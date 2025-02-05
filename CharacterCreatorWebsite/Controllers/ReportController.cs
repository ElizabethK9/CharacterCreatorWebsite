using Microsoft.AspNetCore.Mvc;

namespace CharacterCreatorWebsite.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
