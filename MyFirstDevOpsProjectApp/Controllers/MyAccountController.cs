using Microsoft.AspNetCore.Mvc;

namespace MyFirstDevOpsProjectApp.Controllers
{
    public class MyAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
