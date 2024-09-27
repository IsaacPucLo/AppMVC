using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Moblarte.Areas.Users.Models;

namespace Moblarte.Areas.Users.Pages.Account
{
    public class RegisterModel : PageModel
    {
        public void OnGet()
        { 
        }
        
        
        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel : InputModelRegister
        {
            public IFormFile AvatarImage { get; set; }
        }
    }
}
