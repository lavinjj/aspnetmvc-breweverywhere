using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using BrewEverywhere.Models;

namespace BrewEverywhere.Data
{
    public class BrewEverywhereDBContext : DbContext
    {
        public BrewEverywhereDBContext()
            : base(nameOrConnectionString: "DefaultConnection") { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Adjunct> Adjuncts { get; set; }
        public DbSet<Brewer> Brewers { get; set; }
        public DbSet<Equipment> EquipmentProfiles { get; set; }
        public DbSet<Fermentable> Fermentables { get; set; }
        public DbSet<Hop> Hops { get; set; }
        public DbSet<MashProfile> MashProfiles { get; set; }
        public DbSet<MashStep> MashSteps { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<WaterProfile> WaterProfiles { get; set; }
        public DbSet<Yeast> Yeasts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BrewerConfiguration());
            modelBuilder.Configurations.Add(new AdjunctConfiguration());
            modelBuilder.Configurations.Add(new InventoryAdjunctConfiguration());
            modelBuilder.Configurations.Add(new RecipeAdjunctConfiguration());
            modelBuilder.Configurations.Add(new BrewerInventoryConfiguration());
            modelBuilder.Configurations.Add(new EquipmentConfiguration());
            modelBuilder.Configurations.Add(new InventoryEquipmentConfiguration());
            modelBuilder.Configurations.Add(new RecipeEquipmentConfiguration());
            modelBuilder.Configurations.Add(new FermentableConfiguration());
            modelBuilder.Configurations.Add(new InventoryFermentableConfiguration());
            modelBuilder.Configurations.Add(new RecipeFermentableConfiguration());
            modelBuilder.Configurations.Add(new HopConfiguration());
            modelBuilder.Configurations.Add(new InventoryHopConfiguration());
            modelBuilder.Configurations.Add(new RecipeHopConfiguration());
            modelBuilder.Configurations.Add(new MashProfileConfiguration());
            modelBuilder.Configurations.Add(new RecipeMashProfileConfiguration());
            modelBuilder.Configurations.Add(new MashStepConfiguration());
            modelBuilder.Configurations.Add(new RecipeConfiguration());
            modelBuilder.Configurations.Add(new StyleConfiguration());
            modelBuilder.Configurations.Add(new WaterProfileConfiguration());
            modelBuilder.Configurations.Add(new InventoryWaterProfileConfiguration());
            modelBuilder.Configurations.Add(new RecipeWaterProfileConfiguration());
            modelBuilder.Configurations.Add(new YeastConfiguration());
            modelBuilder.Configurations.Add(new InventoryYeastConfiguration());
            modelBuilder.Configurations.Add(new RecipeYeastConfiguration());
        }
    }
}
