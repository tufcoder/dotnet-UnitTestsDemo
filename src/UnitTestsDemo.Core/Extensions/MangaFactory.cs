using UnitTestsDemo.Core.Models;

namespace UnitTestsDemo.Core.Extensions;

public class MangaFactory
{
    public static Manga CreateManga(string title, IEnumerable<string> genres, decimal price)
    {
        return new Manga {
            Title = title,
            Genres = genres,
            Price = price
        };
    }
}
