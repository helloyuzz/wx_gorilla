using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace com.wechat.gorilla.Pages {
    public class ChangePwdModel : PageModel {
        public void OnGet() {
        }
        public async Task<IActionResult> OnPostAsync() {
            return RedirectToPage("/ChangePwd",new { msg="changed"});
        }
    }
}
