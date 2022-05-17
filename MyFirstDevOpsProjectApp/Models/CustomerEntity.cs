using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstDevOpsProjectApp.Models
{
    public class CustomerEntity
    {
        [Key]
        public int Id { get; set; } = 0;

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string StreetName { get; set; } = "";

        [Column(TypeName = "char(6)")]
        public string PostalCode { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string City { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string Country { get; set; } = "";
    }
}
