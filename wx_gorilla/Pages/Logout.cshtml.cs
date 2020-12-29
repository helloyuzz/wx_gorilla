using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.wechat.gorilla.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace com.wechat.gorilla.Pages {
    public class LogoutModel : PageModel {
        public async Task<IActionResult> OnGet() {
            User user = HttpContext.Session.Get<User>(Globals.SessionKey_CUA);
            if (user == null) {
                return RedirectToPage("Login");
            }
            User = user;
            return Page();
        }
        [BindProperty]
        public User User { get; set; }
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            Globals.Current_user = null;
            HttpContext.Session.Clear();

            return RedirectToPage("Index");
        }
    }
}