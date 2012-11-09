using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrewEverywhere.Models
{
    public class BrewerInventory
    {
        public Guid Id { get; set; }
        public Brewer Brewer { get; set; }
        public Guid BrewerId { get; set; }
        public List<InventoryAdjunct> Adjuncts;
        public List<InventoryFermentable> Fermentables;
        public List<InventoryHop> Hops;
        public List<InventoryWaterProfile> WaterProfiles;
        public List<InventoryYeast> Yeast;
    }
}
