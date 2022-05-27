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

        public IActionResult Categories(int id)
        {
            var categoryEntity = _context.Categories.FirstOrDefault(x => x.Id == id);
            if (categoryEntity == null)
            {
                return NotFound();
            }

            var products = _context.Products.Where(x => x.Categories.Id == id);
            return View(products);
        }
    }
}
