using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerhallEF.Data.Mapping
{
    class OnsiteCourseConfiguration : IEntityTypeConfiguration<OnsiteCourse>
    {
        public void Configure(EntityTypeBuilder<OnsiteCourse> builder)
        {
            builder.Property(e => e.StartDate).HasField("_startDate");
        }
    }
}
