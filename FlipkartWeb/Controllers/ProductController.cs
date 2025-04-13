using Microsoft.AspNetCore.Mvc;

namespace FlipkartWeb.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
