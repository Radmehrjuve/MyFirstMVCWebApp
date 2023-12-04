using Microsoft.AspNetCore.Mvc;
using MyfirstwebApp.WebAppUI.Models;

namespace MyfirstwebApp.WebAppUI.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            News news = new News()
            {
                Id = 1,
                Name = "tatto in iran"
            };
            return View(news);

        }
        public IActionResult Politics()
        {
            News news = new News()
            {
                Id = 2, Name = "Attackon Israel", Section = "MiddleEast"
                
            };
            return View(news);
        }
    }
}
