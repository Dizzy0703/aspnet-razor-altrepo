using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorTests.Data;
using RazorTests.Models;

namespace RazorTests.Pages.Vessels
{
    public class IndexModel : PageModel
    {
        private readonly RazorTests.Data.RazorTestsContext _context;

        public IndexModel(RazorTests.Data.RazorTestsContext context)
        {
            _context = context;
        }

        public IList<Vessel> Vessel { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Vessel != null)
            {
                Vessel = await _context.Vessel.ToListAsync();
            }
        }
    }
}
