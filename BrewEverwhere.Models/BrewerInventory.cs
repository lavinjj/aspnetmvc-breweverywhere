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
        public BrewerInventory()
        {
            Equipment = new List<InventoryEquipment>();
            Adjuncts = new List<InventoryAdjunct>();
            Fermentables = new List<InventoryFermentable>();
            Hops = new List<InventoryHop>();
            WaterProfiles = new List<InventoryWaterProfile>();
            Yeast = new List<InventoryYeast>();
        }

        public Guid Id { get; set; }
        public Brewer Brewer { get; set; }
        public Guid BrewerId { get; set; }
        public List<InventoryEquipment> Equipment { get; set; }
        public List<InventoryAdjunct> Adjuncts { get; set; }
        public List<InventoryFermentable> Fermentables { get; set; }
        public List<InventoryHop> Hops { get; set; }
        public List<InventoryWaterProfile> WaterProfiles { get; set; }
        public List<InventoryYeast> Yeast { get; set; }
        public byte[] Version { get; set; }
    }
}
