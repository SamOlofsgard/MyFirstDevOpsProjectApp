using System.ComponentModel.DataAnnotations;

namespace MyFirstDevOpsProjectApp.Models.Entities
{
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public decimal Price { get; set; }


        [Required]
        public virtual CategoryEntity Categories { get; set; }


    }
}
