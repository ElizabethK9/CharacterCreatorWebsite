namespace CharacterCreatorWebsite.Models.ViewModel
{
    public class CharacterChartViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Nickname { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Occupation { get; set; }
        public string Species { get; set; }
        public string EyeColor { get; set; }
        public List<string> Hobbies { get; set; } = new List<string>();
        public List<string> SkillsOrTalents { get; set; } = new List<string>();
    }

}
