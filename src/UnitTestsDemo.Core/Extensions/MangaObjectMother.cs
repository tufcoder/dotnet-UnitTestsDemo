using UnitTestsDemo.Core.Models;

namespace UnitTestsDemo.Core.Extensions;

public class MangaObjectMother
{
    private static readonly DateTime _releaseDate = new DateTime(2024, 12, 01).AddYears(-4);
    private static readonly DateTime _createdAt = new DateTime(2024, 12, 01);

    public static Manga CreateOnePieceManga()
    {
        return new Manga
        {
            Id = Ulid.NewUlid(),
            Title = "One Piece",
            Genres = new List<MangaGenres>()
            {
                MangaGenres.Shounen,
                MangaGenres.Commedy,
                MangaGenres.Pirates,
            },
            Price = 19.99m,
            ReleaseDate = _releaseDate,
            CreatedAt = _createdAt,
        };
    }

    public static Manga CreateHajimeNoIppoManga()
    {
        return new Manga
        {
            Id = Ulid.NewUlid(),
            Title = "Hajime no Ippo",
            Genres = new List<MangaGenres>()
            {
                MangaGenres.Shounen,
                MangaGenres.Commedy,
                MangaGenres.Boxers,
            },
            Price = 21.99m,
            ReleaseDate = _releaseDate,
            CreatedAt = _createdAt,
        };
    }
}
