using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContactManagement.Data;
using ContactManagement.Models;

namespace ContactManagement.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Contact != null)
            {
                Contact = await _context.Contact.Where(c => c.IsDeleted == false).ToListAsync();
            }
        }
    }
}
