using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using BrewEverywhere.Models;

namespace BrewEverywhere.Data
{
    internal class FermentableConfiguration : EntityTypeConfiguration<Fermentable>
    {
        public FermentableConfiguration()
        {
            Map<Fermentable>(m => m.ToTable("Fermentables"));
            Property(p => p.Version).IsRowVersion();
        }
    }

    internal class InventoryFermentableConfiguration : EntityTypeConfiguration<InventoryFermentable>
    {
        public InventoryFermentableConfiguration()
        {
            HasRequired(t => t.BrewerInventory).WithMany(a => a.Fermentables).HasForeignKey(t => t.BrewerInventoryId);
            Map<InventoryFermentable>(m => m.ToTable("InventoryFermentables"));
        }
    }

    internal class RecipeFermentableConfiguration : EntityTypeConfiguration<RecipeFermentable>
    {
        public RecipeFermentableConfiguration()
        {
            HasRequired(t => t.Recipe).WithMany(a => a.Fermentables).HasForeignKey(t => t.RecipeId);
            Map<RecipeFermentable>(m => m.ToTable("RecipeFermentables"));
        }
    }
}
