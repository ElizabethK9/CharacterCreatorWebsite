using Microsoft.AspNetCore.Mvc;

namespace CharacterCreatorWebsite.Controllers
{
    public class CharacterCreationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
