using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using BrewEverywhere.Models;

namespace BrewEverywhere.Data
{
    internal class RecipeConfiguration : EntityTypeConfiguration<Recipe>
    {
        public RecipeConfiguration()
        {
            HasRequired(t => t.Brewer).WithMany(a => a.Recipies).HasForeignKey(t => t.BrewerId);
            Map<Recipe>(m => m.ToTable("Recipes"));
            Property(p => p.Version).IsRowVersion();
        }
    }
}
