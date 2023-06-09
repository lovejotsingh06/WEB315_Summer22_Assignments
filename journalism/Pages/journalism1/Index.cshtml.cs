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
    public class IndexModel : PageModel
    {
        private readonly journalismContext _context;

        public IndexModel(journalismContext context)
        {
            _context = context;
        }

        public IList<journalism1> journalism1 { get;set; }

        public async Task OnGetAsync()
        {
            journalism1 = await _context.journalism1.ToListAsync();
        }
    }
}
