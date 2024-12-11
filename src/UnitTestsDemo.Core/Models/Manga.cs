namespace UnitTestsDemo.Core.Models;

public enum MangaGenres
{
    None,
    Shounen,
    Commedy,
    Pirates,
    Boxers,
    Sports,
    Ninjas,
}

public class Manga
{
    public Ulid Id { get; set; }
    public required string Title { get; set; }
    public IEnumerable<MangaGenres>? Genres { get; set; }
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }
    public DateTime CreatedAt { get; set; }
}
