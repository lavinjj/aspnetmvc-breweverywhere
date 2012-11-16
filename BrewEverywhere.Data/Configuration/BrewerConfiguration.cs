using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using BrewEverywhere.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrewEverywhere.Data
{
    internal class BrewerConfiguration : EntityTypeConfiguration<Brewer>
    {
        public BrewerConfiguration()
        {
            // table mapping

            // column mapping
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Version).IsRowVersion();

            // relationships
            HasRequired(b => b.Account).WithRequiredPrincipal();
        }
    }
}
