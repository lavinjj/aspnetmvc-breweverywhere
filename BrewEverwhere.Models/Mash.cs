using System;
using System.Linq;
using System.Text;
using System.Xml;
using System.Collections.ObjectModel;

namespace BrewEverywhere.Models
{
    public class Mash
    {
        public Guid Id { get; set; }
        public Guid BrewerId { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
        public double GrainTemp { get; set; }
        public Collection<MashStep> MashSteps { get; set; }
        public string Notes { get; set; }
        public double TUNTemp { get; set; }
        public double SpargeTemp { get; set; }
        public double PH { get; set; }
        public double TUNWeight { get; set; }
        public double TUNSpecificHeat { get; set; }
        public bool EquipAdjust { get; set; }
    }
}
