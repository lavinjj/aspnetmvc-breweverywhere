using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using BrewEverywhere.Models;

namespace BrewEverywhere.Data
{
    internal class BrewerConfiguration : EntityTypeConfiguration<Brewer>
    {
        public BrewerConfiguration()
        {
            HasRequired(b => b.Account).WithRequiredPrincipal();
        }
    }
}
