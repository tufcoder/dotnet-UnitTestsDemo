using Microsoft.EntityFrameworkCore;

using UnitTestsDemo.Core.Models;

namespace UnitTestsDemo.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public DbSet<Manga> Mangas { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
