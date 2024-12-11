using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using UnitTestsDemo.Core.Models;
using UnitTestsDemo.Infrastructure.Data;

namespace UnitTestsDemo.Web.Pages.Mangas;

public class EditModel : PageModel
{
    private readonly AppDbContext _context;

    [BindProperty(SupportsGet = true)]
    public Ulid Id { get; set; }
    public Manga Manga { get; set; } = default!;

    public EditModel(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> OnGetAsync()
    {
        var manga = await _context.Mangas.FindAsync(Id);

        if (manga is null)
            return NotFound();

        Manga = manga;

        return Page();
    }

    public IActionResult OnPostAsync()
    {
        return RedirectToPage("./Index");
    }
}
