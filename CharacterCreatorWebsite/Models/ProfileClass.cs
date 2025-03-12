using System.Collections.Generic; // For List<>
using System.ComponentModel.DataAnnotations;

namespace CharacterCreatorWebsite.Models
{
    public class ProfileClass
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; } // Property for email registration

        [Required]
        public string Password { get; set; }

        public string ConfirmationToken { get; set; } // Property for confirmation tokens (email or password reset)

        public bool IsEmailConfirmed { get; set; } = false; // Default to false for new registrations

        // Navigation property for associated characters
        public ICollection<CharacterClass> Characters { get; set; } = new List<CharacterClass>();
    }
}

