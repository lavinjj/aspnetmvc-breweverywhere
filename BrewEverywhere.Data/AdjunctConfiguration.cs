using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using BrewEverywhere.Models;

namespace BrewEverywhere.Data
{
    internal class AdjunctConfiguration : EntityTypeConfiguration<Adjunct>
    {
        public AdjunctConfiguration()
        {
            // table mapping
            Map<Adjunct>(m => m.ToTable("Adjuncts"));
            
            // column mapping
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Version).IsRowVersion();
            
            // relationships
        }
    }

    internal class InventoryAdjunctConfiguration : EntityTypeConfiguration<InventoryAdjunct>
    {
        public InventoryAdjunctConfiguration()
        {
            // table mapping
            Map<InventoryAdjunct>(m => m.ToTable("InventoryAdjunct"));

            // column mapping 

            // relationships
            HasRequired(t => t.BrewerInventory).WithMany(a => a.Adjuncts).HasForeignKey(t => t.BrewerInventoryId);
        }
    }

    internal class RecipeAdjunctConfiguration : EntityTypeConfiguration<RecipeAdjunct>
    {
        public RecipeAdjunctConfiguration()
        {
            // table mapping
            Map<RecipeAdjunct>(m => m.ToTable("RecipeAdjunct"));

            // column mapping

            // relationships
            HasRequired(t => t.Recipe).WithMany(a => a.Adjuncts).HasForeignKey(t => t.RecipeId);
        }
    }
}
