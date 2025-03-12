using System;
using System.ComponentModel.DataAnnotations;

namespace CharacterCreatorWebsite.Models
{
    public class CharacterClass
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public string Description { get; set; }

        // Foreign key to associate the character with a profile
        public int ProfileClassId { get; set; } // Links to the ProfileClass
        public ProfileClass Profile { get; set; } // Navigation property
    }
}
