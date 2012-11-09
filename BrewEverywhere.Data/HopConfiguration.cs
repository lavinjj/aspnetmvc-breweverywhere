using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using BrewEverywhere.Models;

namespace BrewEverywhere.Data
{
    internal class HopConfiguration : EntityTypeConfiguration<Hop>
    {
        public HopConfiguration()
        {
            Map<Hop>(m => m.ToTable("Hops"));
            Property(p => p.Version).IsRowVersion();
        }
    }

    internal class InventoryHopConfiguration : EntityTypeConfiguration<InventoryHop>
    {
        public InventoryHopConfiguration()
        {
            HasRequired(t => t.BrewerInventory).WithMany(a => a.Hops).HasForeignKey(t => t.BrewerInventoryId);
            Map<InventoryHop>(m => m.ToTable("InventoryHops"));
        }
    }

    internal class RecipeHopConfiguration : EntityTypeConfiguration<RecipeHop>
    {
        public RecipeHopConfiguration()
        {
            HasRequired(t => t.Recipe).WithMany(a => a.Hops).HasForeignKey(t => t.RecipeId);
            Map<RecipeHop>(m => m.ToTable("RecipeHops"));
        }
    }
}
