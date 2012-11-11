using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        public String Name { get; set; }
        [Required]
        public string Email { get; set; }
        public List<Recipe> Recipies { get; set; }
        public BrewerInventory Inventory { get; set; }
        public Guid InventoryId { get; set; }
        public byte[] Version { get; set; }
    }
}
