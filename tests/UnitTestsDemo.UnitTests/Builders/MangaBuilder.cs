using UnitTestsDemo.Core.Models;

namespace UnitTestsDemo.UnitTests.Builders;

public class MangaBuilder
{
    private Ulid _id = Ulid.Empty;
    private string _title = string.Empty;
    private IEnumerable<MangaGenres> _genres = [];
    private decimal _price;
    private DateTime _releaseDate;
    private DateTime _createdAt;

    public MangaBuilder WithNewUlid()
    {
        _id = Ulid.NewUlid();
        return this;
    }

    public MangaBuilder WithCustomUlid(Ulid id)
    {
        _id = id;
        return this;
    }

    public MangaBuilder WithDefaultPrice()
    {
        _price = 9.99m;
        return this;
    }

    public MangaBuilder WithGenre(MangaGenres genre)
    {
        var newGenres = _genres.Append(genre);
        _genres = newGenres;
        return this;
    }

    public MangaBuilder WithTitle(string title)
    {
        _title = title;
        return this;
    }

    public MangaBuilder WithGenres(IEnumerable<MangaGenres> genres)
    {
        _genres = genres;
        return this;
    }

    public MangaBuilder WithPrice(decimal price)
    {
        _price = price;
        return this;
    }

    public MangaBuilder WithReleaseDate(DateTime releaseDate)
    {
        _releaseDate = releaseDate;
        return this;
    }

    public MangaBuilder WithCreatedAt(DateTime createdAt)
    {
        _createdAt = createdAt;
        return this;
    }

    public Manga Build()
    {
        return new Manga
        {
            Id = _id,
            Title = _title,
            Genres = _genres,
            Price = _price,
            ReleaseDate = _releaseDate,
            CreatedAt = _createdAt,
        };
    }
}