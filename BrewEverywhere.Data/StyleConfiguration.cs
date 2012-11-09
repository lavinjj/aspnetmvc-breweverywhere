using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using BrewEverywhere.Models;

namespace BrewEverywhere.Data
{
    internal class StyleConfiguration : EntityTypeConfiguration<Style>
    {
        public StyleConfiguration()
        {
            Map<Style>(m => m.ToTable("Styles"));
            Property(p => p.Version).IsRowVersion();
        }
    }
}
