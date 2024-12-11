using UnitTestsDemo.Core.Extensions;

namespace UnitTestsDemo.UnitTests;

public class MangaObjectMotherTests
{
    [Fact]
    public void Test_OnePieceManga()
    {
        // Arrange
        var expectedManga = MangaObjectMother.CreateOnePieceManga();

        // Act
        var manga = MangaFactory.CreateManga(
            expectedManga.Title,
            expectedManga.Genres!,
            expectedManga.Price,
            expectedManga.ReleaseDate,
            expectedManga.CreatedAt
        );

        // Assert
        Assert.NotNull(manga);
        Assert.Equal(expectedManga.Title, manga.Title);
        Assert.Equal(expectedManga.Genres, manga.Genres);
        Assert.Equal(expectedManga.Price, manga.Price);
        Assert.Equal(expectedManga.ReleaseDate, manga.ReleaseDate);
        Assert.Equal(expectedManga.CreatedAt, manga.CreatedAt);
    }

    [Fact]
    public void Test_HajimeNoIppoManga()
    {
        // Arrange
        var expectedManga = MangaObjectMother.CreateHajimeNoIppoManga();

        // Act
        var manga = MangaFactory.CreateManga(
            expectedManga.Title,
            expectedManga.Genres!,
            expectedManga.Price,
            expectedManga.ReleaseDate,
            expectedManga.CreatedAt
        );

        // Assert
        Assert.NotNull(manga);
        Assert.Equal(expectedManga.Title, manga.Title);
        Assert.Equal(expectedManga.Genres, manga.Genres);
        Assert.Equal(expectedManga.Price, manga.Price);
        Assert.Equal(expectedManga.ReleaseDate, manga.ReleaseDate);
        Assert.Equal(expectedManga.CreatedAt, manga.CreatedAt);
    }
}
