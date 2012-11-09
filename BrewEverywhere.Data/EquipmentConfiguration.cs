using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using BrewEverywhere.Models;

namespace BrewEverywhere.Data
{
    internal class EquipmentConfiguration : EntityTypeConfiguration<Equipment>
    {
        public EquipmentConfiguration()
        {
            Map<Equipment>(m => m.ToTable("Equipment"));
            Property(p => p.Version).IsRowVersion();
        }
    }

    internal class InventoryEquipmentConfiguration : EntityTypeConfiguration<InventoryEquipment>
    {
        public InventoryEquipmentConfiguration()
        {
            HasRequired(t => t.BrewerInventory).WithMany(a => a.Equipment).HasForeignKey(t => t.BrewerInventoryId);
            Map<InventoryEquipment>(m => m.ToTable("InventoryEquipment"));
        }
    }

    internal class RecipeEquipmentConfiguration : EntityTypeConfiguration<RecipeEquipment>
    {
        public RecipeEquipmentConfiguration()
        {
            HasRequired(t => t.Recipe).WithMany(a => a.Equipment).HasForeignKey(t => t.RecipeId);
            Map<RecipeEquipment>(m => m.ToTable("RecipeEquipment"));
        }
    }
}
