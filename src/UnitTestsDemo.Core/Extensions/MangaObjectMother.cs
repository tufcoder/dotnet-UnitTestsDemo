using UnitTestsDemo.Core.Models;

namespace UnitTestsDemo.Core.Extensions;

public class MangaObjectMother
{
    public static Manga CreateOnePieceManga()
    {
        return new Manga
        {
            Title = "One Piece",
            Genres = ["Shounen", "Commedy", "Pirates"],
            Price = 19.99m
        };
    }

    public static Manga CreateHajimeNoIppoManga()
    {
        return new Manga
        {
            Title = "Hajime no Ippo",
            Genres = ["Shounen", "Commedy", "Boxe"],
            Price = 21.99m
        };
    }
}
