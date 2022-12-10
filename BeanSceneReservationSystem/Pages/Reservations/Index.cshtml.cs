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
    public class IndexModel : PageModel
    {
        private readonly BeanSceneReservationSystem.Data.BeanSceneReservationSystemContext _context;

        public IndexModel(BeanSceneReservationSystem.Data.BeanSceneReservationSystemContext context)
        {
            _context = context;
        }

        public IList<Reservation> Reservation { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Reservation != null)
            {
                Reservation = await _context.Reservation.Include(r => r.User).AsNoTracking().ToListAsync();
            }
        }
    }
}
