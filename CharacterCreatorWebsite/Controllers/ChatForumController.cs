using Microsoft.AspNetCore.Mvc;

namespace CharacterCreatorWebsite.Controllers
{
    public class ChatForumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
