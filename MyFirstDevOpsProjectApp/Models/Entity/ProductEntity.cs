using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstDevOpsProjectApp.Models.Entity
{
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; } = 0;

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "Decimal")]
        public decimal Price { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Color { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Size { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Brand { get; set; }

        [Required]
        [Column(TypeName = "Int")]
        public int Amount { get; set; }

      
        [Column(TypeName = "nvarchar(50)")]
        public string Raiting { get; set; }

        public CategoryEntity CategoryName { get; set; }

        public bool IsOnSale { get; set; }
    }
}
