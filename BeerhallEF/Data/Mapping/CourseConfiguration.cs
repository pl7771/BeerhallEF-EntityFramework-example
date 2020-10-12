using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerhallEF.Data.Mapping
{
    class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Course");
            builder.Property(e => e.Title).IsRequired().HasMaxLength(100);
            builder.HasDiscriminator<string>("Type of course")
                .HasValue<OnlineCourse>("Online")
                .HasValue<OnsiteCourse>("Onsite");
        }
    }
}
