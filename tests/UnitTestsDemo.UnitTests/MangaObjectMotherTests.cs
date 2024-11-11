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
        var actualManga = MangaFactory.CreateManga
        (
            "One Piece",
            ["Shounen", "Commedy", "Pirates"],
            19.99m
        );

        // Assert
        Assert.NotNull(actualManga);
        Assert.Equal(expectedManga.Title, actualManga.Title);
        Assert.Equal(expectedManga.Genres, actualManga.Genres);
        Assert.Equal(expectedManga.Price, actualManga.Price);
    }

    [Fact]
    public void Test_HajimeNoIppoManga()
    {
        // Arrange
        var expectedManga = MangaObjectMother.CreateHajimeNoIppoManga();

        // Act
        var actualManga = MangaFactory.CreateManga
        (
            "Hajime no Ippo",
            ["Shounen", "Commedy", "Boxe"],
            21.99m
        );

        // Assert
        Assert.NotNull(actualManga);
        Assert.Equal(expectedManga.Title, actualManga.Title);
        Assert.Equal(expectedManga.Genres, actualManga.Genres);
        Assert.Equal(expectedManga.Price, actualManga.Price);
    }
}
