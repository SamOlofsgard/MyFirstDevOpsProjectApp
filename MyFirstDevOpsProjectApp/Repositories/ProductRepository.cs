using MyFirstDevOpsProjectApp.Models;

namespace MyFirstDevOpsProjectApp.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsAsync();
    }

    public class ProductRepository : IProductRepository
    {

        Task<List<Product>> IProductRepository.GetProductsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
