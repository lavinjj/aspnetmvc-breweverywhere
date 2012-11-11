using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using BrewEverywhere.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrewEverywhere.Data
{
    internal class MashStepConfiguration : EntityTypeConfiguration<MashStep>
    {
        public MashStepConfiguration()
        {
            // table mapping
            Map<MashStep>(m => m.ToTable("MashSteps"));

            // column mapping
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Version).IsRowVersion();

            // relationships
            HasRequired(t => t.MashProfile).WithMany(a => a.MashSteps).HasForeignKey(t => t.MashProfileId);
        }
    }
}
