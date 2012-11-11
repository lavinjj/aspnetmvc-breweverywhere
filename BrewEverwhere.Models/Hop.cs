using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.ComponentModel.DataAnnotations;

namespace BrewEverywhere.Models
{
    public class Hop
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public byte[] Version { get; set; }
        public double Alpha { get; set; } // percent
        public double Amount { get; set; } // weight in kg
        public string Use { get; set; } // can be "Boil", "Dry Hop", "Mash", "First Wort" or "Aroma"
        public double Time { get; set; }  // in minutes
        public string Notes { get; set; }
        public string Type { get; set; } // can be "Bittering", "Armoa" or "Both"
        public string Form { get; set; } // can be "Pellet", "Plug" or "Leaf"
        public double Beta { get; set; } // percent
        public double HSI { get; set; } // percent
        public string Origin { get; set; }
        public string Substitutes { get; set; }
        public double Humulene { get; set; } // percent
        public double Caryophyllene { get; set; } // percent
        public double Cohumulone { get; set; } // percent
        public double Myrcene { get; set; } // percent
    }

    public class InventoryHop : Hop
    {
        public BrewerInventory BrewerInventory { get; set; }
        public Guid BrewerInventoryId { get; set; }
    }

    public class RecipeHop : Hop
    {
        public Recipe Recipe { get; set; }
        public Guid RecipeId { get; set; }
    }
}
