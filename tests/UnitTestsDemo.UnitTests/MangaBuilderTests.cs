using UnitTestsDemo.Core.Extensions;
using UnitTestsDemo.UnitTests.Builders;

namespace UnitTestsDemo.UnitTests;

public class MangaBuilderTests
{
    [Fact]
    public void ActualMangaShouldMatchBuilderManga()
    {
        // Arrange
        var expectedManga = new MangaBuilder()
            .WithTitle("One Piece")
            .WithGenres(["Shounen", "Commedy", "Pirates"])
            .WithPrice(19.99m)
            .Build();

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
}
