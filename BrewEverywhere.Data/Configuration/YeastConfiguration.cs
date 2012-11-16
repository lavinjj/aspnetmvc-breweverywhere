using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using BrewEverywhere.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrewEverywhere.Data
{
    internal class YeastConfiguration : EntityTypeConfiguration<Yeast>
    {
        public YeastConfiguration()
        {
            // table mapping
            Map<Yeast>(m => m.ToTable("Yeasts"));

            // column mapping
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Version).IsRowVersion();

            // relationships
        }
    }

    internal class InventoryYeastConfiguration : EntityTypeConfiguration<InventoryYeast>
    {
        public InventoryYeastConfiguration()
        {
            // table mapping
            Map<InventoryYeast>(m => m.ToTable("InventoryYeast"));

            // column mapping

            // relationships
            HasRequired(t => t.BrewerInventory).WithMany(a => a.Yeast).HasForeignKey(t => t.BrewerInventoryId);
        }
    }

    internal class RecipeYeastConfiguration : EntityTypeConfiguration<RecipeYeast>
    {
        public RecipeYeastConfiguration()
        {
            // table mapping
            Map<RecipeYeast>(m => m.ToTable("RecipeYeast"));

            // column mapping

            // relationships
            HasRequired(t => t.Recipe).WithMany(a => a.Yeast).HasForeignKey(t => t.RecipeId);
        }
    }
}
