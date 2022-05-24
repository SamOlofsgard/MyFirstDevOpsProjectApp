using MyFirstDevOpsProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.Test.ProducServices
{
    public static class ProductsFixtures
    {
        private static List<ProductEntity> _products = new List<ProductEntity>
        {
            new ProductEntity { Id = 1, ProductName = "Product 1", Price = 1  },
            new ProductEntity { Id = 2, ProductName = "Product 2", Price = 2  },
            new ProductEntity { Id = 3, ProductName = "Product 3", Price = 3  }
        };

        public static List<ProductEntity> GetProducts()
        {
            return _products;
        }
    }
}
