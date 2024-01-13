using Microsoft.EntityFrameworkCore;

namespace Deneme.ProjeContext {
    public class Context : DbContext
        {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer ("");
            }
        }
    }