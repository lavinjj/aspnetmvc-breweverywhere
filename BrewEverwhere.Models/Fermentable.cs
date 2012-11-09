using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace BrewEverywhere.Models
{
    public class Fermentable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte[] Version { get; set; }
        public string Type { get; set; } // can be "Grain", "Sugar", "Extract", "Dry Extract" or "Adjunct"
        public double Amount { get; set; }
        public double Yield { get; set; } // percent
        public double Color { get; set; } // Lovibond units (SRM)
        public bool AddAfterBoil { get; set; }
        public string Origin { get; set; }
        public string Supplier { get; set; }
        public string Notes { get; set; }
        public double CoarseFineDiff { get; set; } // percent
        public double Moisture { get; set; } // percent
        public double DiastaticPower { get; set; } // in lintner units
        public double Protein { get; set; } // percent
        public double MaxInBatch { get; set; } // percent
        public bool RecommendMash { get; set; }
        public double IBUGalPerPound { get; set; }
    }

    public class InventoryFermentable : Fermentable
    {
        public BrewerInventory BrewerInventory { get; set; }
        public Guid BrewerInventoryId { get; set; }
    }

    public class RecipeFermentable : Fermentable
    {
        public Recipe Recipe { get; set; }
        public Guid RecipeId { get; set; }
    }
}
