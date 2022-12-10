using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeanSceneResSystem.Data;
using BeanSceneResSystem.Models;

namespace BeanSceneResSystem.Pages.RegisteredUsers
{
    public class DeleteModel : PageModel
    {
        private readonly BeanSceneResSystem.Data.BeanSceneResSystemContext _context;

        public DeleteModel(BeanSceneResSystem.Data.BeanSceneResSystemContext context)
        {
            _context = context;
        }

        [BindProperty]
      public RegisteredUser RegisteredUser { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.RegisteredUsers == null)
            {
                return NotFound();
            }

            var registereduser = await _context.RegisteredUsers.FirstOrDefaultAsync(m => m.UserName == id);

            if (registereduser == null)
            {
                return NotFound();
            }
            else 
            {
                RegisteredUser = registereduser;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null || _context.RegisteredUsers == null)
            {
                return NotFound();
            }
            var registereduser = await _context.RegisteredUsers.FindAsync(id);

            if (registereduser != null)
            {
                RegisteredUser = registereduser;
                _context.RegisteredUsers.Remove(RegisteredUser);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
