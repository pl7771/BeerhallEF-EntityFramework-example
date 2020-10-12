using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerhallEF.Data.Mapping
{
    class BrewerConfiguration : IEntityTypeConfiguration<Brewer>
    {
        public void Configure(EntityTypeBuilder<Brewer> builder)
        {
            builder.ToTable("Brewer");
            builder.HasKey(e => e.BrewerId);
            builder.Property(p => p.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();
            builder.HasMany(e => e.Beers).WithOne().IsRequired().OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.Location).WithMany().HasForeignKey("PostalCode").IsRequired(false).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
