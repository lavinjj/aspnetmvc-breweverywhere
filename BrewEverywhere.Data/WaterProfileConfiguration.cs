using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using BrewEverywhere.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrewEverywhere.Data
{
    internal class WaterProfileConfiguration : EntityTypeConfiguration<WaterProfile>
    {
        public WaterProfileConfiguration()
        {
            // table mapping
            Map<WaterProfile>(m => m.ToTable("WaterProfiles"));

            // column mapping
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Version).IsRowVersion();

            // relationships
        }
    }

    internal class InventoryWaterProfileConfiguration : EntityTypeConfiguration<InventoryWaterProfile>
    {
        public InventoryWaterProfileConfiguration()
        {
            // table mapping
            Map<InventoryWaterProfile>(m => m.ToTable("InventoryWaterProfile"));

            // column mapping

            // relationships
            HasRequired(t => t.BrewerInventory).WithMany(a => a.WaterProfiles).HasForeignKey(t => t.BrewerInventoryId);
        }
    }

    internal class RecipeWaterProfileConfiguration : EntityTypeConfiguration<RecipeWaterProfile>
    {
        public RecipeWaterProfileConfiguration()
        {
            // table mapping
            Map<RecipeWaterProfile>(m => m.ToTable("RecipeWaterProfile"));

            // column mapping

            // relationships
            HasRequired(t => t.Recipe).WithOptional(a => a.WaterProfile);
        }
    }
}
