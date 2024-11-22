using System;

using UnitTestsDemo.Core.Extensions;
using UnitTestsDemo.Core.Models;

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
    public void Test_OnePieceFullPropsManga()
    {
        // Arrange
        var expectedManga = MangaObjectMother.CreateOnePieceManga();

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

    [Fact]
    public void Test_HajimeNoIppoManga()
    {
        // Arrange
        var expectedManga = MangaObjectMother.CreateHajimeNoIppoManga();

        // Act
        var actualManga = MangaFactory.CreateManga
        (
            "Hajime no Ippo",
            new List<MangaGenres>() {
                MangaGenres.Shounen,
                MangaGenres.Commedy,
                MangaGenres.Boxe,
            },
            21.99m
        );

        // Assert
        Assert.NotNull(actualManga);
        Assert.Equal(expectedManga.Title, actualManga.Title);
        Assert.Equal(expectedManga.Genres, actualManga.Genres);
        Assert.Equal(expectedManga.Price, actualManga.Price);
    }

    [Fact]
    public void Test_HajimeNoIppoFullPropsManga()
    {
        // Arrange
        var expectedManga = MangaObjectMother.CreateHajimeNoIppoManga();

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
