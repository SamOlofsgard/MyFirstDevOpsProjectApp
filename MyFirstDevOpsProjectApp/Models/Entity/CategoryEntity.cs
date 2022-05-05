using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstDevOpsProjectApp.Models.Entity
{
    public class CategoryEntity
    {
        [Key]
        public int Id { get; set; } = 0;

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
    }
}
