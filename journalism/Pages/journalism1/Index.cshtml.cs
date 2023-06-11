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
    public class IndexModel : PageModel
    {
        private readonly journalismContext _context;

        public IndexModel(journalismContext context)
        {
            _context = context;
        }

        
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Name { get; set; }
        [BindProperty(SupportsGet = true)]
        public string journalism1Name { get; set; }
        public IList<journalism1> journalism1 { get;set; }

        public async Task OnGetAsync()
        {

            IQueryable<string> NameQuery = from m in _context.journalism1
                                    orderby m.Name
                                    select m.Name;

            var Journalism1 = from m in _context.journalism1
            select m;
            if (!string.IsNullOrEmpty(SearchString))
    {
             Journalism1 = Journalism1.Where(s => s.Country.Contains(SearchString));
    }

    if (!string.IsNullOrEmpty(journalism1Name))
    {
        Journalism1 = Journalism1.Where(x => x.Name == journalism1Name);
    }
 Name = new SelectList(await NameQuery.Distinct().ToListAsync());
            journalism1 = await _context.journalism1.ToListAsync();
        }
    }
}
