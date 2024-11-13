using UnitTestsDemo.Core.Models;

namespace UnitTestsDemo.UnitTests.Builders;

public class MangaBuilder
{
    private string _title = string.Empty;
    private IEnumerable<string> _genres = [];
    private decimal _price;

    public MangaBuilder WithDefaultPrice()
    {
        _price = 9.99m;
        return this;
    }

    public MangaBuilder WithGenre(string genre)
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

    public MangaBuilder WithGenres(IEnumerable<string> genres)
    {
        _genres = genres;
        return this;
    }

    public MangaBuilder WithPrice(decimal price)
    {
        _price = price;
        return this;
    }

    public Manga Build()
    {
        return new Manga
        {
            Title = _title,
            Genres = _genres,
            Price = _price
        };
    }
}
