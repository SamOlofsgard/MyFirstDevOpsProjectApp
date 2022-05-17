using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstDevOpsProjectApp.Models
{
    public class OrderRowEntity
    {
        [Key]
        public int Id { get; set; } = 0;

        [Required]
        [Column(TypeName = "Int")]
        public int Quantity { get; set; }
        [Required]
        [Column(TypeName = "Decimal")]
        public decimal TotalProductPrice { get; set; }

        public OrderEntity OrderId { get; set; }
    }
}
