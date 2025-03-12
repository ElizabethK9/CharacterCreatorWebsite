using System.ComponentModel.DataAnnotations;

namespace CharacterCreatorWebsite.Models
{
    public class CharacterChartClass
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Nicknames { get; set; }
        public string Gender { get; set; }
        public string Species { get; set; }
        public string PlaceOfBirth { get; set; }
        public string DateOfBirth { get; set; }
        public string CurrentResidence { get; set; }
        public string BloodStatus { get; set; }
        public string MagicalInheritance { get; set; }
        public string LordLadyShips { get; set; }
        public string MagicLegacy { get; set; }
        public string ImportantFamily { get; set; }
        public string Parents { get; set; }
        public string Siblings { get; set; }
        public string MagicAbilities { get; set; }
        public string MagicCore { get; set; }
        public string Alignment { get; set; }
        public string Appearance { get; set; }
        public int Age { get; set; }
        public string HogwartsHouse { get; set; }
        public string Wand { get; set; }
        public string Patronus { get; set; }
        public string SpecialItems { get; set; }
        public string Style { get; set; }
        public string Miscellaneous { get; set; }
    }
}
