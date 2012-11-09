using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace BrewEverywhere.Models
{
    public class Brewer
    {
        public Brewer()
        {
            Recipies = new List<Recipe>();
        }
        public Guid Id { get; set; }
        public Account Account { get; set; }
        public Guid AccountId { get; set; }
        public String Name { get; set; }
        public string Email { get; set; }
        public List<Recipe> Recipies { get; set; }
        public BrewerInventory Inventory { get; set; }
        public Guid InventoryId { get; set; }
    }
}
