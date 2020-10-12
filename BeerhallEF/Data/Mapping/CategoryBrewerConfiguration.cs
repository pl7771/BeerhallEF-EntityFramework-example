using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeerhallEF.Data
{
    internal class CategoryBrewerConfiguration : IEntityTypeConfiguration<CategoryBrewer>
    {
        public void Configure(EntityTypeBuilder<CategoryBrewer> builder)
        {
            builder.ToTable("CategoryBrewer");
            builder.HasKey(e => new { e.CategoryId, e.BrewerId });
            builder.HasOne(e => e.Category).WithMany(e => e.CategoryBrewers).HasForeignKey(e => e.CategoryId)
                .IsRequired().OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.Brewer).WithMany().HasForeignKey(e => e.BrewerId)
                .IsRequired().OnDelete(DeleteBehavior.Cascade);
            

        }
    }
}