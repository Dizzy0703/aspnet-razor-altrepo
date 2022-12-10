using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorTests.Data;
using RazorTests.Models;

namespace RazorTests.Pages.Vessels
{
    public class CreateModel : PageModel
    {
        private readonly RazorTests.Data.RazorTestsContext _context;

        public CreateModel(RazorTests.Data.RazorTestsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Vessel Vessel { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Vessel == null || Vessel == null)
            {
                return Page();
            }

            _context.Vessel.Add(Vessel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
