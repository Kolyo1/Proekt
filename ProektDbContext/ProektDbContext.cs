using Microsoft.EntityFrameworkCore;
using ProektDbContext.Model;

namespace ProektDbContext
{
    public class ProektDbContexts : DbContext
    {
        public DbSet<Town> Towns { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<University> Universities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-S10U54F\SQLEXPRESS;Database=Priemi;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}