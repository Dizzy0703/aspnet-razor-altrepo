using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BeanSceneReservationSystem.Data;
using BeanSceneReservationSystem.Models;

namespace BeanSceneReservationSystem.Pages.Reservations
{
    public class CreateModel : PageModel
    {
        private readonly BeanSceneReservationSystem.Data.BeanSceneReservationSystemContext _context;

        public CreateModel(BeanSceneReservationSystem.Data.BeanSceneReservationSystemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
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

            _context.Reservation.Add(Reservation);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
