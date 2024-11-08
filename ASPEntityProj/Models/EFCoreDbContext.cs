using Microsoft.EntityFrameworkCore;

namespace ASPEntityProj.Models
{
    public class EFCoreDbContext : DbContext
    {
        public EFCoreDbContext(DbContextOptions<EFCoreDbContext> options) : base(options) 
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Employee> Employees { get; set; } 
        public DbSet<Departament> Departamentes { get; set; }
    }
}
