using System.ComponentModel.DataAnnotations;

namespace MyFirstDevOpsProjectApp.Models
{
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }


    }
}
