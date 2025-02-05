using Microsoft.EntityFrameworkCore;
using CharacterCreatorWebsite.Models; // Ensure this namespace is correct

namespace CharacterCreatorWebsite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CharacterCreationClass> Characters { get; set; }

        // Override the OnModelCreating method to configure model properties
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CharacterCreationClass>(entity =>
            {
                entity.Property(e => e.Income).HasColumnType("decimal(18,2)");
            });
        }
    }
}


