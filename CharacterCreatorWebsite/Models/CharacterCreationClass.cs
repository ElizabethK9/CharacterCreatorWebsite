
using System;
using System.ComponentModel.DataAnnotations;

namespace CharacterCreatorWebsite.Models
{
    public class CharacterCreationClass
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Species { get; set; }

        public string Residence { get; set; }

        public decimal Income { get; set; }
    }
}