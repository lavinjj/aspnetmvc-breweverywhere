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
            base.OnModelCreating(modelBuilder);
        }
    }
}
