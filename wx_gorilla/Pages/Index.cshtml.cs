using com.wechat.gorilla.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla.Pages {
    public class IndexModel : PublicPage {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger) {
            _logger = logger;
        }

        public async Task<IActionResult> OnGet() {
            User user = HttpContext.Session.Get<User>(SessionExtensions.SessionKey_CUA);
            if (user == null) {
                return RedirectToPage("Login");
            }
            SessionExtensions.Set<string>(HttpContext.Session, SessionExtensions.SessionKey_ActiveMenuId, "navMenu_Index");
            return Page();
            //if (Globals.Cua == null) {
        }
    }
}
