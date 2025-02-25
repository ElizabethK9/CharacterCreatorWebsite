using Microsoft.AspNetCore.Mvc;

namespace CharacterCreatorWebsite.Controllers
{
    public class CharacterChartController : Controller
    {
        public IActionResult Index()
        {
            return View("CharacterChart");
        }
    }
}
