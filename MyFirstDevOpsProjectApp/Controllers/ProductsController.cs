using Microsoft.AspNetCore.Mvc;
using MyFirstDevOpsProjectApp.Repositories;

namespace MyFirstDevOpsProjectApp.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepository @object;

        public ProductsController(IProductRepository @object)
        {
            this.@object = @object;
        }

        public async Task <IActionResult> Index()
        {
            var products = await @object.GetProductsAsync();
            return View(products);
        }
    }
}
