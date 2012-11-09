using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using BrewEverywhere.Models;

namespace BrewEverywhere.Data
{
    internal class MashStepConfiguration : EntityTypeConfiguration<MashStep>
    {
        public MashStepConfiguration()
        {
            HasRequired(t => t.MashProfile).WithMany(a => a.MashSteps).HasForeignKey(t => t.MashProfileId);
            Map<MashStep>(m => m.ToTable("MashSteps"));
            Property(p => p.Version).IsRowVersion();
        }
    }
}
