using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using BrewEverywhere.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrewEverywhere.Data
{
    internal class HopConfiguration : EntityTypeConfiguration<Hop>
    {
        public HopConfiguration()
        {
            // table mapping
            Map<Hop>(m => m.ToTable("Hops"));

            // column mapping
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Version).IsRowVersion();

            // relationships
        }
    }

    internal class InventoryHopConfiguration : EntityTypeConfiguration<InventoryHop>
    {
        public InventoryHopConfiguration()
        {
            // table mapping
            Map<InventoryHop>(m => m.ToTable("InventoryHops"));

            // column mapping

            // relationships
            HasRequired(t => t.BrewerInventory).WithMany(a => a.Hops).HasForeignKey(t => t.BrewerInventoryId);
        }
    }

    internal class RecipeHopConfiguration : EntityTypeConfiguration<RecipeHop>
    {
        public RecipeHopConfiguration()
        {
            // table mapping
            Map<RecipeHop>(m => m.ToTable("RecipeHops"));

            // column mapping

            // relationships
            HasRequired(t => t.Recipe).WithMany(a => a.Hops).HasForeignKey(t => t.RecipeId);
        }
    }
}
