using Microsoft.AspNetCore.Mvc;
using Moq;
using MyFirstDevOpsProjectApp.Controllers;
using MyFirstDevOpsProjectApp.Models;
using MyFirstDevOpsProjectApp.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ProjectApp.Test.ProducServices
{
    public class ProductControllerTest
    {
        [Fact]
        public async Task Index_Should_Return_ViewResult_With_List_Of_3_Products()
        {
            //Arrange
            var productRepository = new Mock<IProductRepository>();

            productRepository.Setup(x => x.GetProductsAsync())
            .ReturnsAsync(ProductsFixtures.GetProducts());

            var sut = new ProductsController(productRepository.Object);


            //Act
            var result = await sut.Index();


            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<Product>>(viewResult.ViewData.Model);
            Assert.Equal(3, model.Count());
        }
    }
}
