using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using BrewEverywhere.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrewEverywhere.Data
{
    internal class EquipmentConfiguration : EntityTypeConfiguration<Equipment>
    {
        public EquipmentConfiguration()
        {
            // table mapping
            Map<Equipment>(m => m.ToTable("Equipment"));

            // column mapping
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Version).IsRowVersion();

            // relationships
        }
    }

    internal class InventoryEquipmentConfiguration : EntityTypeConfiguration<InventoryEquipment>
    {
        public InventoryEquipmentConfiguration()
        {
            // table mapping
            Map<InventoryEquipment>(m => m.ToTable("InventoryEquipment"));

            // column mapping

            // relationships
            HasRequired(t => t.BrewerInventory).WithMany(a => a.Equipment).HasForeignKey(t => t.BrewerInventoryId);
        }
    }

    internal class RecipeEquipmentConfiguration : EntityTypeConfiguration<RecipeEquipment>
    {
        public RecipeEquipmentConfiguration()
        {
            // table mapping
            Map<RecipeEquipment>(m => m.ToTable("RecipeEquipment"));

            // column mapping

            // relationships
            HasRequired(t => t.Recipe).WithMany(a => a.Equipment).HasForeignKey(t => t.RecipeId);
        }
    }
}
