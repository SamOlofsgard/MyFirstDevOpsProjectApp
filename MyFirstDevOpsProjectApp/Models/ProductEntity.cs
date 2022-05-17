using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstDevOpsProjectApp.Models
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
        public Colors Color { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public Brands Brand { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public Sizes Size { get; set; }

        [Required]
        [Column(TypeName = "Int")]
        public int Amount { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        public string Rating { get; set; }

        public CategoryEntity CategoryName { get; set; }

        public bool IsOnSale { get; set; }
    }
    public enum Colors
    {
        Pink,
        Red, 
        Orange,
        Yellow,
        Green,
        Blue,
        Purple,
        Brown,
        Grey,
        Beige,
        Silver,
        Gold,
        Multi,
        Black,
        White

    }
    public enum Brands
    {
        Bexim,
        Lighton,
        Dismis,
        Rosimo,
        Dalls,
    }

    
    public enum Sizes
    {
        XS,
        S,
        M,
        L,
        XL,
        XXL

    }
}
