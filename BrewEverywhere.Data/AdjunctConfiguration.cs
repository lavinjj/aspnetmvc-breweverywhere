using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using BrewEverywhere.Models;

namespace BrewEverywhere.Data
{
    internal class AdjunctConfiguration : EntityTypeConfiguration<Adjunct>
    {
        public AdjunctConfiguration()
        {
            Map<Adjunct>(m => m.ToTable("Adjuncts"));
            Property(p => p.Version).IsRowVersion();
        }
    }

    internal class InventoryAdjunctConfiguration : EntityTypeConfiguration<InventoryAdjunct>
    {
        public InventoryAdjunctConfiguration()
        {
            HasRequired(t => t.BrewerInventory).WithMany(a => a.Adjuncts).HasForeignKey(t => t.BrewerInventoryId);
            Map<InventoryAdjunct>(m => m.ToTable("InventoryAdjunct"));
        }
    }

    internal class RecipeAdjunctConfiguration : EntityTypeConfiguration<RecipeAdjunct>
    {
        public RecipeAdjunctConfiguration()
        {
            HasRequired(t => t.Recipe).WithMany(a => a.Adjuncts).HasForeignKey(t => t.RecipeId);
            Map<RecipeAdjunct>(m => m.ToTable("RecipeAdjunct"));
        }
    }
}
