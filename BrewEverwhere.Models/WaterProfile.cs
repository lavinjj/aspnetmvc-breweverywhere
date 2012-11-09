using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace BrewEverywhere.Models
{
    public class WaterProfile
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte[] Version { get; set; }
        public double Amount { get; set; } // in liter
        public double Calcium { get; set; }
        public double Bicarbonate { get; set; }
        public double Sulfate { get; set; }
        public double Chloride { get; set; }
        public double Sodium { get; set; }
        public double Magnesium { get; set; }
        public double PH { get; set; }
        public string Notes { get; set; }
    }

    public class InventoryWaterProfile : WaterProfile
    {
        public BrewerInventory BrewerInventory { get; set; }
        public Guid BrewerInventoryId { get; set; }
    }

    public class RecipeWaterProfile : WaterProfile
    {
        public Recipe Recipe { get; set; }
        public Guid RecipeId { get; set; }
    }
}
