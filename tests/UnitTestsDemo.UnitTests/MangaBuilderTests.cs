using UnitTestsDemo.Core.Extensions;
using UnitTestsDemo.Core.Models;
using UnitTestsDemo.UnitTests.Builders;

namespace UnitTestsDemo.UnitTests;

public class MangaBuilderTests
{
    private readonly DateTime _releaseDate = new DateTime(2024, 12, 01).AddYears(-4);
    private readonly DateTime _createdAt = new DateTime(2024, 12, 01);

    [Fact]
    public void ActualMangaShouldMatchBuilderManga()
    {
        // Arrange
        var expectedManga = new MangaBuilder()
            .WithTitle("One Piece")
            .WithGenres(
                new List<MangaGenres>()
                {
                    MangaGenres.Shounen,
                    MangaGenres.Commedy,
                    MangaGenres.Pirates,
                }
            )
            .WithPrice(19.99m)
            .Build();

        // Act
        var actualManga = MangaFactory.CreateManga
        (
            "One Piece",
            new List<MangaGenres>() {
                MangaGenres.Shounen,
                MangaGenres.Commedy,
                MangaGenres.Pirates,
            },
            19.99m
        );

        // Assert
        Assert.NotNull(actualManga);
        Assert.Equal(expectedManga.Title, actualManga.Title);
        Assert.Equal(expectedManga.Genres, actualManga.Genres);
        Assert.Equal(expectedManga.Price, actualManga.Price);
    }

    [Fact]
    public void ActualMangaShouldMatchBuilderDefaultValuesManga()
    {
        // Arrange
        var expectedManga = new MangaBuilder()
            .WithTitle("Hajime no Ippo")
            .WithGenres(
                new List<MangaGenres>()
                {
                    MangaGenres.Shounen,
                    MangaGenres.Commedy,
                }
            )
            .WithDefaultPrice()
            .WithGenre(MangaGenres.Boxers)
            .WithReleaseDate(_releaseDate)
            .WithCreatedAt(_createdAt)
            .Build();

        // Act
        var manga = MangaFactory.CreateManga
        (
            expectedManga.Title,
            expectedManga.Genres,
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
