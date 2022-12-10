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
    public class DeleteModel : PageModel
    {
        private readonly RazorTests.Data.RazorTestsContext _context;

        public DeleteModel(RazorTests.Data.RazorTestsContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Vessel Vessel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Vessel == null)
            {
                return NotFound();
            }

            var vessel = await _context.Vessel.FirstOrDefaultAsync(m => m.ID == id);

            if (vessel == null)
            {
                return NotFound();
            }
            else 
            {
                Vessel = vessel;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Vessel == null)
            {
                return NotFound();
            }
            var vessel = await _context.Vessel.FindAsync(id);

            if (vessel != null)
            {
                Vessel = vessel;
                _context.Vessel.Remove(Vessel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
