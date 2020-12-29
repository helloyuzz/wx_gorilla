using com.wechat.gorilla.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla.Pages {
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger) {
            _logger = logger;
        }

        public async Task<IActionResult> OnGet() {
            User user = HttpContext.Session.Get<User>(Globals.SessionKey_CUA);
            if (user == null) {
                return RedirectToPage("Login");
            }

            return Page();
            //if (Globals.Cua == null) {
        }
    }
}
