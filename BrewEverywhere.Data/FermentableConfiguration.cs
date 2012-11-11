using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using BrewEverywhere.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrewEverywhere.Data
{
    internal class FermentableConfiguration : EntityTypeConfiguration<Fermentable>
    {
        public FermentableConfiguration()
        {
            // table mapping
            Map<Fermentable>(m => m.ToTable("Fermentables"));

            // column mapping
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Version).IsRowVersion();

            // relationships
        }
    }

    internal class InventoryFermentableConfiguration : EntityTypeConfiguration<InventoryFermentable>
    {
        public InventoryFermentableConfiguration()
        {
            // table mapping
            Map<InventoryFermentable>(m => m.ToTable("InventoryFermentables"));

            // column mapping

            // relationships
            HasRequired(t => t.BrewerInventory).WithMany(a => a.Fermentables).HasForeignKey(t => t.BrewerInventoryId);
        }
    }

    internal class RecipeFermentableConfiguration : EntityTypeConfiguration<RecipeFermentable>
    {
        public RecipeFermentableConfiguration()
        {
            // table mapping
            Map<RecipeFermentable>(m => m.ToTable("RecipeFermentables"));

            // column mapping

            // relationships
            HasRequired(t => t.Recipe).WithMany(a => a.Fermentables).HasForeignKey(t => t.RecipeId);
        }
    }
}
