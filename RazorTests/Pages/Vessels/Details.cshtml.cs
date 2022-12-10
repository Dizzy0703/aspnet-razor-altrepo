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
    public class DetailsModel : PageModel
    {
        private readonly RazorTests.Data.RazorTestsContext _context;

        public DetailsModel(RazorTests.Data.RazorTestsContext context)
        {
            _context = context;
        }

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
    }
}
