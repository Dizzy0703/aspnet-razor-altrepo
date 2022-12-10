using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BeanSceneResSystem.Data;
using BeanSceneResSystem.Models;

namespace BeanSceneResSystem.Pages.Reservations
{
    public class CreateModel : PageModel
    {
        private readonly BeanSceneResSystem.Data.BeanSceneResSystemContext _context;

        public CreateModel(BeanSceneResSystem.Data.BeanSceneResSystemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["UserID"] = new SelectList(_context.Users, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Reservation Reservation { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Reservations.Add(Reservation);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
