using Microsoft.EntityFrameworkCore;

using UnitTestsDemo.Core.Models;

namespace UnitTestsDemo.Infrastructure.Extensions;

public static class ModelBuilderExtension
{
    public static ModelBuilder SeedDatabase(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Manga>().HasData(
            new Manga
            {
                Id = Ulid.Parse("01JESEPBKR0EJH3R3Q8YC66MT5"),
                Title = "Naruto",
                Genres = new List<MangaGenres>
                {
                    MangaGenres.Shounen,
                    MangaGenres.Commedy,
                    MangaGenres.Ninjas
                },
                Price = 10.99m,
                ReleaseDate = new DateTime(1999, 09, 21),
                CreatedAt = new DateTime(2020, 01, 01),
            }
        );

        return modelBuilder;
    }
}
