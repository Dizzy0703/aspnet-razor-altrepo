using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeanSceneReservationSystem.Data;
using BeanSceneReservationSystem.Models;

namespace BeanSceneReservationSystem.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly BeanSceneReservationSystem.Data.BeanSceneReservationSystemContext _context;

        public DetailsModel(BeanSceneReservationSystem.Data.BeanSceneReservationSystemContext context)
        {
            _context = context;
        }

      public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.User == null)
            {
                return NotFound();
            }

            var user = await _context.User.FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            else 
            {
                User = user;
            }
            return Page();
        }
    }
}
