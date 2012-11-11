using System;
using System.Linq;
using System.Text;
using System.Xml;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BrewEverywhere.Models
{
    public class MashProfile
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public byte[] Version { get; set; }
        public double GrainTemp { get; set; }
        public List<MashStep> MashSteps { get; set; }
        public string Notes { get; set; }
        public double TUNTemp { get; set; }
        public double SpargeTemp { get; set; }
        public double PH { get; set; }
        public double TUNWeight { get; set; }
        public double TUNSpecificHeat { get; set; }
        public bool EquipAdjust { get; set; }
    }

    public class RecipeMashProfile : MashProfile
    {
        public Recipe Recipe { get; set; }
        public Guid RecipeId { get; set; }
    }
}
