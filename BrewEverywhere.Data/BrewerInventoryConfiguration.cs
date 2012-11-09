using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using BrewEverywhere.Models;

namespace BrewEverywhere.Data
{
    internal class BrewerInventoryConfiguration : EntityTypeConfiguration<BrewerInventory>
    {
        public BrewerInventoryConfiguration()
        {
            HasRequired(i => i.Brewer).WithOptional(b => b.Inventory);
            Property(p => p.Version).IsRowVersion();
        }
    }
}
