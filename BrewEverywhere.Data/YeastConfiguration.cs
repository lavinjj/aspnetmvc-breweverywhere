using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using BrewEverywhere.Models;

namespace BrewEverywhere.Data
{
    internal class YeastConfiguration : EntityTypeConfiguration<Yeast>
    {
        public YeastConfiguration()
        {
            Map<Yeast>(m => m.ToTable("Yeasts"));
            Property(p => p.Version).IsRowVersion();
        }
    }

    internal class InventoryYeastConfiguration : EntityTypeConfiguration<InventoryYeast>
    {
        public InventoryYeastConfiguration()
        {
            HasRequired(t => t.BrewerInventory).WithMany(a => a.Yeast).HasForeignKey(t => t.BrewerInventoryId);
            Map<InventoryYeast>(m => m.ToTable("InventoryYeast"));
        }
    }

    internal class RecipeYeastConfiguration : EntityTypeConfiguration<RecipeYeast>
    {
        public RecipeYeastConfiguration()
        {
            HasRequired(t => t.Recipe).WithMany(a => a.Yeast).HasForeignKey(t => t.RecipeId);
            Map<RecipeYeast>(m => m.ToTable("RecipeYeast"));
        }
    }
}
