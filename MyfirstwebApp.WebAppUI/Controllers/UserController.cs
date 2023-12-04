using Microsoft.AspNetCore.Mvc;

namespace MyfirstwebApp.WebAppUI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
