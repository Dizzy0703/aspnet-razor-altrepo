using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeanSceneResSystem.Data;
using BeanSceneResSystem.Models;

namespace BeanSceneResSystem.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly BeanSceneResSystem.Data.BeanSceneResSystemContext _context;

        public DetailsModel(BeanSceneResSystem.Data.BeanSceneResSystemContext context)
        {
            _context = context;
        }

      public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            //var user = await _context.Users.FirstOrDefaultAsync(m => m.ID == id);
            var user = await _context.Users.Include(u => u.Reservations).FirstOrDefaultAsync(m => m.ID == id);
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
