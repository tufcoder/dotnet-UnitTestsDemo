namespace UnitTestsDemo.Core.Models;

public enum MangaGenres
{
    None,
    Shounen,
    Commedy,
    Pirates,
    Boxe,
    Sports,
}

public class Manga
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public IEnumerable<MangaGenres> Genres { get; set; } = [];
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }
    public DateTime CreatedAt { get; set; }
}
