using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstDevOpsProjectApp.Controllers;
using MyFirstDevOpsProjectApp.Models;
using MyFirstDevOpsProjectApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProjectApp.Test.xUnit.Test
{
    public class ProductControllerTest
    {
        [Fact(DisplayName = "Index Should Return Valid Model")]
        public void Index_Should_Return_Valid_Model()
        {
            using var context = GetContextWithData();
            using var controller = new ProductController(context);
            var result = controller.Index() as ViewResult;
            var model = result.Model as FrontEndModel;

            Assert.NotNull(model);
            Assert.NotNull(model.Take3);
            Assert.Equal(3, model.Take3.Count());
        }

        public static DataContext GetContextWithData()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new DataContext(options);

            var shoes = new CategoryEntity { Id = 1, Name = "Shoes" };
            var jeans = new CategoryEntity { Id = 2, Name = "Jeans" };
            var jackets = new CategoryEntity { Id = 3, Name = "Jackets" };

            context.Add(shoes);
            context.Add(jeans);
            context.Add(jackets);

            context.Products.Add(new ProductEntity { Id = 1, ProductName = "Adidas Stan Smith Shoes", Price = 100, Categories = shoes });
            context.Products.Add(new ProductEntity { Id = 2, ProductName = "Levis 501", Price = 200, Categories = jeans });
            context.Products.Add(new ProductEntity { Id = 3, ProductName = "Carthatt Men's Crowley Work Jacket", Price = 300, Categories = jackets });

            context.SaveChanges();

            return context;
        }
    }
}
