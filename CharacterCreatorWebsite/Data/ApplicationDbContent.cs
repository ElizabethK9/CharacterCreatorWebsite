using Microsoft.EntityFrameworkCore;
using CharacterCreatorWebsite.Models; 

namespace CharacterCreatorWebsite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet for Profiles table
        public DbSet<ProfileClass> Profiles { get; set; }

        // DbSet for Characters table
        public DbSet<CharacterClass> Characters { get; set; } // Added CharacterClass

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the Characters entity
            modelBuilder.Entity<CharacterClass>(entity =>
            {
                entity.HasOne(c => c.Profile) // Relationship with ProfileClass
                      .WithMany(p => p.Characters)
                      .HasForeignKey(c => c.ProfileClassId)
                      .OnDelete(DeleteBehavior.Cascade); // Ensure cascading delete

                entity.Property(e => e.Name).IsRequired(); // Ensure Name is required
                entity.Property(e => e.Description); // Optional description
                entity.Property(e => e.CreatedOn).HasDefaultValueSql("GETDATE()"); // Default timestamp
            });

            // Optional: Configure the Profiles entity
            modelBuilder.Entity<ProfileClass>(entity =>
            {
                entity.Property(p => p.Username).IsRequired().HasMaxLength(50);
                entity.Property(p => p.Password).IsRequired();
            });
        }
    }
}




