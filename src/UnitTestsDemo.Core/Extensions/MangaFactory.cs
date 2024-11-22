﻿using UnitTestsDemo.Core.Models;

namespace UnitTestsDemo.Core.Extensions;

public class MangaFactory
{
    public static Manga CreateManga(string title, IEnumerable<MangaGenres> genres, decimal price)
    {
        return new Manga
        {
            Title = title,
            Genres = genres,
            Price = price
        };
    }

    public static Manga CreateManga
    (
        string title,
        IEnumerable<MangaGenres> genres,
        decimal price,
        DateTime releaseDate,
        DateTime createdAt
    )
    {
        return new Manga
        {
            Title = title,
            Genres = genres,
            Price = price,
            ReleaseDate = releaseDate,
            CreatedAt = createdAt
        };
    }
}