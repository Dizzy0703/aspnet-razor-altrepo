using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeanSceneReservationSystem.Data;
using BeanSceneReservationSystem.Models;

namespace BeanSceneReservationSystem.Pages.Reservations
{
    public class DetailsModel : PageModel
    {
        private readonly BeanSceneReservationSystem.Data.BeanSceneReservationSystemContext _context;

        public DetailsModel(BeanSceneReservationSystem.Data.BeanSceneReservationSystemContext context)
        {
            _context = context;
        }

      public Reservation Reservation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Reservation == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation.FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }
            else 
            {
                Reservation = reservation;
            }
            return Page();
        }
    }
}
