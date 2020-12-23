using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.wechat.gorilla;
using com.wechat.gorilla.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace com.wechat.gorilla.Pages {
    public class LoginModel : PageModel {
        public void OnGet() {
            //Globals.Cua = new Account();
        }
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            string account = Request.Form["uac_account"];
            string pwd = Request.Form["uac_pwd"];
            if (account.Equals("aa") && pwd.Equals("aa")) {
                Globals.Cua = new Account();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
