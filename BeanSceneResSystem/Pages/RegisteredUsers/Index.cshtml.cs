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
    public class IndexModel : PageModel
    {
        private readonly BeanSceneResSystem.Data.BeanSceneResSystemContext _context;

        public IndexModel(BeanSceneResSystem.Data.BeanSceneResSystemContext context)
        {
            _context = context;
        }

        public IList<RegisteredUser> RegisteredUser { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.RegisteredUsers != null)
            {
                RegisteredUser = await _context.RegisteredUsers.ToListAsync();
            }
        }
    }
}
