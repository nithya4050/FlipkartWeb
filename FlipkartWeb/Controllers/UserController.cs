using Microsoft.AspNetCore.Mvc;
using FlipkartWeb.Models;


namespace FlipkartWeb.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View(new RegModel());
        }

        [HttpPost]
        public IActionResult SaveData()
        {
             return View(new RegModel());
        }

    }
}
