using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using BrewEverywhere.Models;

namespace BrewEverywhere.Data
{
    internal class MashProfileConfiguration : EntityTypeConfiguration<MashProfile>
    {
        public MashProfileConfiguration()
        {
            Map<MashProfile>(m => m.ToTable("MashProfiles"));
            Property(p => p.Version).IsRowVersion();
        }
    }

    internal class RecipeMashProfileConfiguration : EntityTypeConfiguration<RecipeMashProfile>
    {
        public RecipeMashProfileConfiguration()
        {
            HasRequired(p => p.Recipe).WithRequiredPrincipal();
            Map<RecipeMashProfile>(m => m.ToTable("RecipeMashProfiles"));
        }
    }
}
