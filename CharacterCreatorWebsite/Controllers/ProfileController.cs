using Microsoft.AspNetCore.Mvc;

namespace CharacterCreatorWebsite.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
