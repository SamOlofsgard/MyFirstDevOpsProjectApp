using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstDevOpsProjectApp.Models.Entity
{
    public class OrderEntity
    {
        [Key]
        public int Id { get; set; } = 0;

      
        public CustomerEntity CustomerId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public OrderStatus Order { get; set; }
        [Required]
        [Column(TypeName = "DateTime")]
        public DateTime OrderDate { get; set; }
        [Required]
        [Column(TypeName = "DateTime")]
        public DateTime DeliverDate { get; set; }
        [Required]
        [Column(TypeName = "Decimal")]
        public decimal ShippingFee { get; set; }
        [Required]
        [Column(TypeName = "Decimal")]
        public decimal TotalPrice { get; set; }
    }

    public enum OrderStatus
    {

        Onhold,
        Initialized,
        Delivered,
        Finished 


    }
}
