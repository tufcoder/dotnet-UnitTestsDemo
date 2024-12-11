using Microsoft.EntityFrameworkCore;

using UnitTestsDemo.Core.Extensions;
using UnitTestsDemo.Core.Models;

namespace UnitTestsDemo.Infrastructure.Data;

public class DbInitializer
{
    private static readonly Manga Naruto = MangaFactory.CreateManga(
        "Naruto",
        new List<MangaGenres>
        {
            MangaGenres.Shounen,
            MangaGenres.Commedy,
            MangaGenres.Ninjas
        },
        10.99m,
        new DateTime(2020, 01, 01),
        DateTime.Now
    );

    public static async Task InitializeAsync(AppDbContext dbContext)
    {
        if (await dbContext.Mangas.AnyAsync()) return;

        await PopulateDataAsync(dbContext);
    }

    private static async Task PopulateDataAsync(AppDbContext dbContext)
    {
        dbContext.Mangas.Add(Naruto);
        await dbContext.SaveChangesAsync();
    }
}