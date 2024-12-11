using Microsoft.EntityFrameworkCore;

using UnitTestsDemo.Core.Models;
using UnitTestsDemo.Infrastructure.Configurations;
using UnitTestsDemo.Infrastructure.Extensions;

namespace UnitTestsDemo.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public DbSet<Manga> Mangas { get; set; } = null!;

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // new MangaConfiguration().Configure(modelBuilder.Entity<Manga>());
        modelBuilder
            .ApplyConfiguration(new MangaConfiguration())
            .SeedDatabase();
    }
}
