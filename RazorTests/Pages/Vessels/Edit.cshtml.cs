using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorTests.Data;
using RazorTests.Models;

namespace RazorTests.Pages.Vessels
{
    public class EditModel : PageModel
    {
        private readonly RazorTests.Data.RazorTestsContext _context;

        public EditModel(RazorTests.Data.RazorTestsContext context)
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

            var vessel =  await _context.Vessel.FirstOrDefaultAsync(m => m.ID == id);
            if (vessel == null)
            {
                return NotFound();
            }
            Vessel = vessel;
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

            _context.Attach(Vessel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VesselExists(Vessel.ID))
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

        private bool VesselExists(int id)
        {
          return (_context.Vessel?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
