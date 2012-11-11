using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using BrewEverywhere.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrewEverywhere.Data
{
    internal class MashProfileConfiguration : EntityTypeConfiguration<MashProfile>
    {
        public MashProfileConfiguration()
        {
            // table mapping
            Map<MashProfile>(m => m.ToTable("MashProfiles"));

            // column mapping
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Version).IsRowVersion();

            // relationships
        }
    }

    internal class RecipeMashProfileConfiguration : EntityTypeConfiguration<RecipeMashProfile>
    {
        public RecipeMashProfileConfiguration()
        {
            // table mapping
            Map<RecipeMashProfile>(m => m.ToTable("RecipeMashProfiles"));

            // column mapping

            // relationships
            HasRequired(p => p.Recipe).WithRequiredPrincipal();
        }
    }
}
