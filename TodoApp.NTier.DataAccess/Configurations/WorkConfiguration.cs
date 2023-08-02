﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoApp.NTier.Entities.Domains;

namespace TodoApp.NTier.DataAccess.Configurations
{
    public class WorkConfiguration : IEntityTypeConfiguration<Work>
    {
        public void Configure(EntityTypeBuilder<Work> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Definition).HasMaxLength(300);
            builder.Property(x => x.Definition).IsRequired(true);

            builder.Property(x => x.IsCompleted).IsRequired(true);
        }
    }
}
