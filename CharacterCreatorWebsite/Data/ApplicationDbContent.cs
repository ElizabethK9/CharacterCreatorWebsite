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

        public DbSet<CharacterChartClass> CharacterCharts { get; set; }


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

            // Configure the Profiles entity
            modelBuilder.Entity<ProfileClass>(entity =>
            {
                entity.Property(p => p.Username).IsRequired().HasMaxLength(50);
                entity.Property(p => p.Password).IsRequired();
            });

            // Seed data for CharacterChartClass
            modelBuilder.Entity<CharacterChartClass>().HasData(
                new CharacterChartClass
                {
                    Id = 1,
                    FullName = "Template Character 1",
                    Nicknames = "Nickname 1",
                    Gender = "Unknown",
                    Species = "Unknown",
                    PlaceOfBirth = "Unknown",
                    DateOfBirth = "Unknown",
                    CurrentResidence = "Unknown",
                    BloodStatus = "Unknown",
                    MagicalInheritance = "None",
                    LordLadyShips = "None",
                    MagicLegacy = "None",
                    ImportantFamily = "None",
                    Parents = "None",
                    Siblings = "None",
                    MagicAbilities = "None",
                    MagicCore = "Unknown",
                    Alignment = "Neutral",
                    Appearance = "Unknown",
                    Age = 0,
                    HogwartsHouse = "Unknown",
                    Wand = "Unknown",
                    Patronus = "Unknown",
                    SpecialItems = "None",
                    Style = "Unknown",
                    Miscellaneous = "None"
                },
                new CharacterChartClass
                {
                    Id = 2,
                    FullName = "Template Character 2",
                    Nicknames = "Nickname 2",
                    Gender = "Unknown",
                    Species = "Unknown",
                    PlaceOfBirth = "Unknown",
                    DateOfBirth = "Unknown",
                    CurrentResidence = "Unknown",
                    BloodStatus = "Unknown",
                    MagicalInheritance = "None",
                    LordLadyShips = "None",
                    MagicLegacy = "None",
                    ImportantFamily = "None",
                    Parents = "None",
                    Siblings = "None",
                    MagicAbilities = "None",
                    MagicCore = "Unknown",
                    Alignment = "Neutral",
                    Appearance = "Unknown",
                    Age = 0,
                    HogwartsHouse = "Unknown",
                    Wand = "Unknown",
                    Patronus = "Unknown",
                    SpecialItems = "None",
                    Style = "Unknown",
                    Miscellaneous = "None"
                }
            );
        }

    }
}




