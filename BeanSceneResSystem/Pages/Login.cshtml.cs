using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BeanSceneResSystem.Models;
using BeanSceneResSystem.Data;

namespace BeanSceneResSystem.Pages
{
    public class LoginModel : PageModel
    {
        private readonly BeanSceneResSystem.Data.BeanSceneResSystemContext _context;

        public LoginModel(BeanSceneResSystem.Data.BeanSceneResSystemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public RegisteredUser RegUser { get; set; }

        public ActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (_context.RegisteredUsers.Contains(RegUser))
            {
                return RedirectToPage("./Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
