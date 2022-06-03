using MyFirstDevOpsProjectApp.Models;
using Xunit;
using System.Linq;

namespace ModelEntityTests
{
    public class ModelEntitiesUnitTest
    {
        [Fact]
        public void CategoryEntity_CorrectProperties()
        {
            // Arrange
            var properties = typeof(CategoryEntity).GetProperties();

            // Assert
            Assert.Equal(2, properties.Length);
            // Assert that name has required attribute
            Assert.Contains(properties
                .Where(prop => prop.Name == "Name").FirstOrDefault()?.CustomAttributes, 
                ca => ca.AttributeType.Name == "RequiredAttribute");
        }

        [Fact]
        public void CustomerEntity_CorrectProperties()
        {
            // Arrange
            var properties = typeof(CustomerEntity).GetProperties();

            // Assert
            Assert.Equal(7, properties.Length);
            // Assert that FirstName and LastName has required attribute
            Assert.Contains(properties
                .Where(prop => prop.Name == "FirstName").FirstOrDefault()?.CustomAttributes,
                ca => ca.AttributeType.Name == "RequiredAttribute");
            Assert.Contains(properties
                .Where(prop => prop.Name == "LastName").FirstOrDefault()?.CustomAttributes,
                ca => ca.AttributeType.Name == "RequiredAttribute");
        }

        [Fact]
        public void OrderEntity_CorrectProperties()
        {
            // Arrange
            var properties = typeof(OrderEntity).GetProperties();

            // Assert
            Assert.Equal(7, properties.Length);
            // Assert that properties listed has required attribute
            Assert.Contains(properties
                .Where(prop => prop.Name == "Order").FirstOrDefault()?.CustomAttributes,
                ca => ca.AttributeType.Name == "RequiredAttribute");
            Assert.Contains(properties
                .Where(prop => prop.Name == "OrderDate").FirstOrDefault()?.CustomAttributes,
                ca => ca.AttributeType.Name == "RequiredAttribute");
            Assert.Contains(properties
                .Where(prop => prop.Name == "DeliverDate").FirstOrDefault()?.CustomAttributes,
                ca => ca.AttributeType.Name == "RequiredAttribute");
            Assert.Contains(properties
                .Where(prop => prop.Name == "ShippingFee").FirstOrDefault()?.CustomAttributes,
                ca => ca.AttributeType.Name == "RequiredAttribute");
            Assert.Contains(properties
                .Where(prop => prop.Name == "TotalPrice").FirstOrDefault()?.CustomAttributes,
                ca => ca.AttributeType.Name == "RequiredAttribute");
        }

        [Fact]
        public void OrderRowEntity_CorrectProperties()
        {
            // Arrange
            var properties = typeof(OrderRowEntity).GetProperties();

            // Assert
            Assert.Equal(5, properties.Length);
            // Assert that properties listed has required attribute
            Assert.Contains(properties
                .Where(prop => prop.Name == "Quantity").FirstOrDefault()?.CustomAttributes,
                ca => ca.AttributeType.Name == "RequiredAttribute");
            Assert.Contains(properties
                .Where(prop => prop.Name == "TotalProductPrice").FirstOrDefault()?.CustomAttributes,
                ca => ca.AttributeType.Name == "RequiredAttribute");
        }

        [Fact]
        public void ProductEtityEntity_CorrectProperties()
        {
            // Arrange
            var properties = typeof(ProductEntity).GetProperties();

            // Assert
            Assert.Equal(11, properties.Length);
            // Assert that properties listed has required attribute
            Assert.Contains(properties
                .Where(prop => prop.Name == "Name").FirstOrDefault()?.CustomAttributes,
                ca => ca.AttributeType.Name == "RequiredAttribute");
            Assert.Contains(properties
                .Where(prop => prop.Name == "Description").FirstOrDefault()?.CustomAttributes,
                ca => ca.AttributeType.Name == "RequiredAttribute");
            Assert.Contains(properties
                .Where(prop => prop.Name == "Price").FirstOrDefault()?.CustomAttributes,
                ca => ca.AttributeType.Name == "RequiredAttribute");
            Assert.Contains(properties
                .Where(prop => prop.Name == "Color").FirstOrDefault()?.CustomAttributes,
                ca => ca.AttributeType.Name == "RequiredAttribute");
            Assert.Contains(properties
                .Where(prop => prop.Name == "Brand").FirstOrDefault()?.CustomAttributes,
                ca => ca.AttributeType.Name == "RequiredAttribute");
            Assert.Contains(properties
                .Where(prop => prop.Name == "Size").FirstOrDefault()?.CustomAttributes,
                ca => ca.AttributeType.Name == "RequiredAttribute");
            Assert.Contains(properties
                .Where(prop => prop.Name == "Amount").FirstOrDefault()?.CustomAttributes,
                ca => ca.AttributeType.Name == "RequiredAttribute");
        }
    }
}