using CharacterCreatorWebsite.Models;

namespace CharacterCreatorWebsite.ViewModels
{
    public class ProfileViewModel
    {
        public string Username { get; set; }
        public CharacterClass MostRecentCharacter { get; set; }
    }
}
