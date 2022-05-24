using MyFirstDevOpsProjectApp.Models;

namespace MyFirstDevOpsProjectApp.Repositories
{
    public interface IProductRepository
    {
        Task<List<ProductEntity>> GetProductsAsync();
    }

    public class ProductRepository : IProductRepository
    {

        Task<List<ProductEntity>> IProductRepository.GetProductsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
