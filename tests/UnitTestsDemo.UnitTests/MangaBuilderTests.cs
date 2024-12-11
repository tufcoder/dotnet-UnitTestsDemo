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
            .WithNewUlid()
            .WithTitle("One Piece")
            .WithGenres(
                new List<MangaGenres>()
                {
                    MangaGenres.Shounen,
                    MangaGenres.Commedy,
                    MangaGenres.Pirates,
                }
            )
            .WithReleaseDate(_releaseDate)
            .WithCreatedAt(_createdAt)
            .WithPrice(19.99m)
            .Build();

        // Act
        var manga = MangaFactory.CreateManga(
            "One Piece",
            new List<MangaGenres>()
            {
                MangaGenres.Shounen,
                MangaGenres.Commedy,
                MangaGenres.Pirates,
            },
            19.99m,
            _releaseDate,
            _createdAt
        );

        // Assert
        Assert.NotNull(manga);
        Assert.NotEqual(expectedManga.Id, manga.Id);
        Assert.Equal(expectedManga.Title, manga.Title);
        Assert.Equal(expectedManga.Genres, manga.Genres);
        Assert.Equal(expectedManga.Price, manga.Price);
        Assert.Equal(expectedManga.ReleaseDate, manga.ReleaseDate);
        Assert.Equal(expectedManga.CreatedAt, manga.CreatedAt);
    }

    [Fact]
    public void ActualMangaShouldMatchBuilderDefaultValuesManga()
    {
        // Arrange
        var expectedManga = new MangaBuilder()
            .WithCustomUlid(Ulid.NewUlid())
            .WithTitle("Hajime no Ippo")
            .WithGenres(new List<MangaGenres>() { MangaGenres.Shounen, MangaGenres.Commedy })
            .WithDefaultPrice()
            .WithGenre(MangaGenres.Boxers)
            .WithReleaseDate(_releaseDate)
            .WithCreatedAt(_createdAt)
            .Build();

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
        Assert.NotEqual(expectedManga.Id, manga.Id);
        Assert.Equal(expectedManga.Title, manga.Title);
        Assert.Equal(expectedManga.Genres, manga.Genres);
        Assert.Equal(expectedManga.Price, manga.Price);
        Assert.Equal(expectedManga.ReleaseDate, manga.ReleaseDate);
        Assert.Equal(expectedManga.CreatedAt, manga.CreatedAt);
    }
}
