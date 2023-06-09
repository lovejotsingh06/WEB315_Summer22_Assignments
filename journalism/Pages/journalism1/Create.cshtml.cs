using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using journalism.Models;

namespace journalism.Pages_journalism1
{
    public class CreateModel : PageModel
    {
        private readonly journalismContext _context;

        public CreateModel(journalismContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public journalism1 journalism1 { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.journalism1.Add(journalism1);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
