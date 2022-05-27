using Microsoft.EntityFrameworkCore;
using MyFirstDevOpsProjectApp.Models.Entities;

namespace MyFirstDevOpsProjectApp.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public virtual DbSet<ProductEntity> Products { get; set; }
        public virtual DbSet<CategoryEntity> Categories { get; set; }

    }


}
