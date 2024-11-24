using Bogus;

using UnitTestsDemo.Core.Extensions;
using UnitTestsDemo.Core.Models;

namespace UnitTestsDemo.UnitTests;

public class MangaFactoryTests
{
    private readonly Faker _faker;

    public MangaFactoryTests()
    {
        _faker = new Faker();
    }

    private Manga CreateRandomManga()
    {
        return new Manga()
        {
            Title = _faker.Commerce.ProductName(),
            Genres = new List<MangaGenres>()
            {
                _faker.Random.Enum<MangaGenres>(),
                _faker.Random.Enum<MangaGenres>(),
                _faker.Random.Enum<MangaGenres>()
            },
            Price = _faker.Finance.Amount(),
            ReleaseDate = _faker.Date.Past(),
            CreatedAt = _faker.Date.Soon()
        };
    }

    [Fact]
    public void Test_CreateManga()
    {
        // Arrange
        var randomManga = CreateRandomManga();

        // Act
        var manga = MangaFactory.CreateManga
        (
            randomManga.Title,
            randomManga.Genres,
            randomManga.Price,
            randomManga.ReleaseDate,
            randomManga.CreatedAt
        );

        // Assert
        Assert.NotNull(manga);
        Assert.Equal(randomManga.Title, manga.Title);
        Assert.Equal(randomManga.Genres, manga.Genres);
        Assert.Equal(randomManga.Price, manga.Price);
        Assert.Equal(randomManga.ReleaseDate, manga.ReleaseDate);
        Assert.Equal(randomManga.CreatedAt, manga.CreatedAt);
    }
}
