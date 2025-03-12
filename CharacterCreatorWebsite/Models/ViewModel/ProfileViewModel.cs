using System;
using System.Collections.Generic;
using CharacterCreatorWebsite.Models;

namespace CharacterCreatorWebsite.ViewModels
{
    public class ProfileViewModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime DateRegistered { get; set; }
        public CharacterClass? MostRecentCharacter { get; set; }
        public List<CharacterClass> AllCharacters { get; set; } = new List<CharacterClass>();
        public string PreferredTheme { get; set; } = "Light"; // Default to Light theme
        public bool IsEmailConfirmed { get; set; }
    }
}
