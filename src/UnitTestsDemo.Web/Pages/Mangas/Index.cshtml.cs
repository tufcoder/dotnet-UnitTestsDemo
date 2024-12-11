using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using UnitTestsDemo.Core.Models;
using UnitTestsDemo.Infrastructure.Data;

namespace UnitTestsDemo.Web.Pages.Mangas
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AppDbContext _context;

        [BindProperty]
        public IList<Manga> Manga { get; set; } = default!;

        public IndexModel(ILogger<IndexModel> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Manga = await _context.Mangas.ToListAsync();

            return Page();
        }
    }
}
