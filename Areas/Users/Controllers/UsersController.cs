using Microsoft.AspNetCore.Mvc;

namespace Moblarte.Areas.Users.Controllers
{
    [Area("Users")]
    public class UsersController : Controller
    {
        public IActionResult Users()
        {
            return View();
        }
    }
}
