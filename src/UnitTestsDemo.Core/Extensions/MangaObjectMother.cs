using UnitTestsDemo.Core.Models;

namespace UnitTestsDemo.Core.Extensions;

public class MangaObjectMother
{
    public static Manga CreateOnePieceManga()
    {
        return new Manga
        {
            Title = "One Piece",
            Genres = new List<MangaGenres>() {
                MangaGenres.Shounen,
                MangaGenres.Commedy,
                MangaGenres.Pirates,
            },
            Price = 19.99m,
            ReleaseDate = new DateTime(2024, 12, 01).AddYears(-4),
            CreatedAt = new DateTime(2024, 12, 01)
        };
    }

    public static Manga CreateHajimeNoIppoManga()
    {
        return new Manga
        {
            Title = "Hajime no Ippo",
            Genres = new List<MangaGenres>() {
                MangaGenres.Shounen,
                MangaGenres.Commedy,
                MangaGenres.Boxe,
            },
            Price = 21.99m,
            ReleaseDate = new DateTime(2024, 12, 01).AddYears(-4),
            CreatedAt = new DateTime(2024, 12, 01)
        };
    }
}
