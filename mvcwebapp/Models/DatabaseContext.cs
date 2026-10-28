using Microsoft.EntityFrameworkCore;
using mvcwebapp.Models.Entities;
namespace mvcwebapp.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        { 
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
            ;
        }
        DbSet<User> Users { get; set; }
    }
}
