using Bogus;

using UnitTestsDemo.Core.Extensions;

namespace UnitTestsDemo.UnitTests;

public class MangaFactoryTests
{
    private readonly Faker _faker;

    public MangaFactoryTests()
    {
        _faker = new Faker();
    }

    [Fact]
    public void Test_CreateManga()
    {
        // Arrange
        var mangaTitle = _faker.Commerce.ProductName();
        var mangaGenres = _faker.Random.WordsArray(3);
        var mangaPrice = _faker.Finance.Amount();

        // Act
        var manga = MangaFactory.CreateManga(mangaTitle, mangaGenres, mangaPrice);

        // Assert
        Assert.NotNull(manga);
        Assert.Equal(mangaTitle, manga.Title);
        Assert.Equal(mangaGenres, manga.Genres);
        Assert.Equal(mangaPrice, manga.Price);
    }
}
