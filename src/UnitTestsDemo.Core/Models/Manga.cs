namespace UnitTestsDemo.Core.Models;

public class Manga
{
    public required string Title { get; set; }
    public IEnumerable<string> Genres { get; set; } = [];
    public decimal Price { get; set; }
}
