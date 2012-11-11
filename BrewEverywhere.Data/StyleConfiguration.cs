using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using BrewEverywhere.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrewEverywhere.Data
{
    internal class StyleConfiguration : EntityTypeConfiguration<Style>
    {
        public StyleConfiguration()
        {
            // table mapping
            Map<Style>(m => m.ToTable("Styles"));

            // column mapping
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Version).IsRowVersion();

            // relationships
        }
    }
}
