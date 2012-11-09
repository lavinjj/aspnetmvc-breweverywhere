using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using BrewEverywhere.Models;

namespace BrewEverywhere.Data
{
    internal class WaterProfileConfiguration : EntityTypeConfiguration<WaterProfile>
    {
        public WaterProfileConfiguration()
        {
            Map<WaterProfile>(m => m.ToTable("WaterProfiles"));
            Property(p => p.Version).IsRowVersion();
        }
    }

    internal class InventoryWaterProfileConfiguration : EntityTypeConfiguration<InventoryWaterProfile>
    {
        public InventoryWaterProfileConfiguration()
        {
            HasRequired(t => t.BrewerInventory).WithMany(a => a.WaterProfiles).HasForeignKey(t => t.BrewerInventoryId);
            Map<InventoryWaterProfile>(m => m.ToTable("InventoryWaterProfile"));
        }
    }

    internal class RecipeWaterProfileConfiguration : EntityTypeConfiguration<RecipeWaterProfile>
    {
        public RecipeWaterProfileConfiguration()
        {
            HasRequired(t => t.Recipe).WithOptional(a => a.WaterProfile);
            Map<RecipeWaterProfile>(m => m.ToTable("RecipeWaterProfile"));
        }
    }
}
