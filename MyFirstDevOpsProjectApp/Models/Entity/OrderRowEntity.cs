using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstDevOpsProjectApp.Models.Entity
{
    public class OrderRowEntity
    {
        [Key]
        public int Id { get; set; } = 0;

 
        public ProductEntity ProductId { get; set; }

        [Required]
        [Column(TypeName = "Int")]
        public int Quantity { get; set; }
        [Required]
        [Column(TypeName = "Decimal")]
        public decimal TotalProductPrice { get; set; }

         public OrderEntity OrderId { get; set; }
    }
}
