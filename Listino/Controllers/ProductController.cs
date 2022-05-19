using Microsoft.AspNetCore.Mvc;

namespace Listino.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
