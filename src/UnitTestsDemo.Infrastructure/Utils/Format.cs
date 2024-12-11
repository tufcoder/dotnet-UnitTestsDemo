using System.Text;

using UnitTestsDemo.Core.Models;

namespace UnitTestsDemo.Infrastructure.Utils;

public static class Format
{
    public static string FormatGenresToLineWithComma(IEnumerable<MangaGenres>? genres)
    {
        if (genres is null)
            return string.Empty;

        StringBuilder sbGenres = new();

        foreach (var genre in genres)
        {
            sbGenres.Append($"{genre}, ");
        }

        sbGenres.Remove(sbGenres.Length - 2, 2);

        return sbGenres.ToString();
    }

    public static string FormatShortDate(DateTime date)
    {
        return date.ToShortDateString();
    }

    public static string FormatPrice(decimal price)
    {
        return $"$ {price}";
    }
}
