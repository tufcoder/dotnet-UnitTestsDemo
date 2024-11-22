using System.Diagnostics;

using Bogus;

using UnitTestsDemo.Core.Extensions;
using UnitTestsDemo.Core.Models;

using static Bogus.DataSets.Name;

namespace UnitTestsDemo.UnitTests;

public class MangaFactoryTests
{
    private readonly Faker _faker;

    public MangaFactoryTests()
    {
        _faker = new Faker();
    }

    public Manga CreateRandomManga()
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
        var title = _faker.Commerce.ProductName();
        var genres = new List<MangaGenres>()
        {
            _faker.Random.Enum<MangaGenres>(),
            _faker.Random.Enum<MangaGenres>(),
            _faker.Random.Enum<MangaGenres>()
        };
        var price = _faker.Finance.Amount();

        // Act
        var manga = MangaFactory.CreateManga(title, genres, price);

        // Assert
        Assert.NotNull(manga);
        Assert.Equal(title, manga.Title);
        Assert.Equal(genres, manga.Genres);
        Assert.Equal(price, manga.Price);
    }

    [Fact]
    public void Test_CreateMangaFullProps()
    {
        // Arrange
        var title = _faker.Commerce.ProductName();
        var genres = new List<MangaGenres>()
        {
            _faker.Random.Enum<MangaGenres>(),
            _faker.Random.Enum<MangaGenres>(),
            _faker.Random.Enum<MangaGenres>()
        };
        var price = _faker.Finance.Amount();
        var releaseDate = _faker.Date.Past();
        var createdAt = _faker.Date.Soon();

        // Act
        var manga = MangaFactory.CreateManga(title, genres, price, releaseDate, createdAt);

        // Assert
        Assert.NotNull(manga);
        Assert.Equal(title, manga.Title);
        Assert.Equal(genres, manga.Genres);
        Assert.Equal(price, manga.Price);
        Assert.Equal(releaseDate, manga.ReleaseDate);
        Assert.Equal(createdAt, manga.CreatedAt);
    }

    [Fact]
    public void Test_CreateRandomManga()
    {
        // Arrange
        var randomManga = CreateRandomManga();

        // Act
        var manga = MangaFactory.CreateManga(
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
