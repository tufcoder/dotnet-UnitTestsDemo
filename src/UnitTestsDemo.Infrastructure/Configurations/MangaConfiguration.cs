﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using UnitTestsDemo.Core.Models;

namespace UnitTestsDemo.Infrastructure.Configurations;

public class MangaConfiguration : IEntityTypeConfiguration<Manga>
{
    public void Configure(EntityTypeBuilder<Manga> builder)
    {
        builder.Property(p => p.Price).HasPrecision(18, 2);
    }
}