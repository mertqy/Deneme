using Deneme.Entity;
using Microsoft.EntityFrameworkCore;

namespace Deneme.ProjeContext {
    public class Context : DbContext
        {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer ("server=PC-M\\SQLEXPRESS;database=DbNewOopCore;integrated security=true;TrustServerCertificate=True;");
            }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Catagory> Catagories { get; set; }

        }
    }