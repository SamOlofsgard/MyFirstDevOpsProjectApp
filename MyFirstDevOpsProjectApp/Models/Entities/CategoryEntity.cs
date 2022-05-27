using System.ComponentModel.DataAnnotations;

namespace MyFirstDevOpsProjectApp.Models.Entities
{
    public class CategoryEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<ProductEntity> Products { get; set; }
    }
}
