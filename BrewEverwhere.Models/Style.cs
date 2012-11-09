using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrewEverywhere.Models.Entities
{
    public class Style
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
        public string Category { get; set; }
        public string CategoryNumber { get; set; } // BJCP style guide int
        public string StyleLetter { get; set; } // BJCP style letter
        public string StyleGuide { get; set; } // "BJCP", "AHA", etc
        public string Type { get; set; } // can be "Lager", "Ale", "Mead", "Wheat", "Mixed" or "Cider"
        public double OGMin { get; set; }
        public double OGMax { get; set; }
        public double FGMin { get; set; }
        public double FGMax { get; set; }
        public double IBUMin { get; set; }
        public double IBUMax { get; set; }
        public double ColorMin { get; set; }
        public double ColorMax { get; set; }
        public double CarbMin { get; set; }
        public double CarbMax { get; set; }
        public double ABVMin { get; set; }
        public double ABVMax { get; set; }
        public string Notes { get; set; }
        public string Profile { get; set; }
        public string Ingredients { get; set; }
        public string Examples { get; set; }
    }
}
