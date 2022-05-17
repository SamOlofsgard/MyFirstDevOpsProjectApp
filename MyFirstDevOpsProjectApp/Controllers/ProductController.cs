using Microsoft.AspNetCore.Mvc;

namespace MyFirstDevOpsProjectApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
