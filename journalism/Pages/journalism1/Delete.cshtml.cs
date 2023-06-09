using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using journalism.Models;

namespace journalism.Pages_journalism1
{
    public class DeleteModel : PageModel
    {
        private readonly journalismContext _context;

        public DeleteModel(journalismContext context)
        {
            _context = context;
        }

        [BindProperty]
        public journalism1 journalism1 { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            journalism1 = await _context.journalism1.FirstOrDefaultAsync(m => m.ID == id);

            if (journalism1 == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            journalism1 = await _context.journalism1.FindAsync(id);

            if (journalism1 != null)
            {
                _context.journalism1.Remove(journalism1);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
