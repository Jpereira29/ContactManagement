using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContactManagement.Data;
using ContactManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManagement.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Contact Contact { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Contact == null || Contact == null)
            {
                return RedirectToPage("./Index");
            }

            var hasContact = await _context.Contact.FirstOrDefaultAsync(c => c.EmailAddress == Contact.EmailAddress ||
               c.ContactNumber == Contact.ContactNumber);

            if (hasContact != null)
            {
                return RedirectToPage("./Index");
            }
            _context.Contact.Add(Contact);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
