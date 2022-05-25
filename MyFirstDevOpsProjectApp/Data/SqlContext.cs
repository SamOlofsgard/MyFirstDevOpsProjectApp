using Microsoft.EntityFrameworkCore;
using MyFirstDevOpsProjectApp.Models;

namespace MyFirstDevOpsProjectApp.Data
{
    public class SqlContext: DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<CustomerEntity> Customers { get; set; }
        public virtual DbSet<OrderEntity> Orders { get; set; }
        public virtual DbSet<OrderRowEntity> OrderRows { get; set; }
        public virtual DbSet<ProductEntity> Products { get; set; }
        public virtual DbSet<CategoryEntity> Categories { get; set; }
    }
    
}
