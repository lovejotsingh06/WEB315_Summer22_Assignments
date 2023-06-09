using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using journalism.Models;

namespace journalism.Pages_journalism1
{
    public class EditModel : PageModel
    {
        private readonly journalismContext _context;

        public EditModel(journalismContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(journalism1).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!journalism1Exists(journalism1.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool journalism1Exists(int id)
        {
            return _context.journalism1.Any(e => e.ID == id);
        }
    }
}
