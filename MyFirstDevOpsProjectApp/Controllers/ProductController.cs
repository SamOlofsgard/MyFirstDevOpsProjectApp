using Microsoft.AspNetCore.Mvc;
using MyFirstDevOpsProjectApp.Models;

namespace MyFirstDevOpsProjectApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = new FrontEndModel
            {
                Take3 = _context.Products.Take(3)
            };

            return View(model);
        }

    }
}
