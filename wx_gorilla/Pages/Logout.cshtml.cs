using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.wechat.gorilla.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace com.wechat.gorilla.Pages {
    public class LogoutModel : PublicPage {
        public async Task<IActionResult> OnGet() {
            User user = HttpContext.Session.Get<User>(SessionExtensions.SessionKey_CUA);
            if (user == null) {
                return RedirectToPage("Login");
            }
            User = user;

            _CrumbList.Add(new CrumbItem("退出系统", true,true));
            ViewData["CrumbList"] = _CrumbList;
            return Page();
        }
        [BindProperty]
        public User User { get; set; }
        public async Task<IActionResult> OnPostAsync() {
            //if (!ModelState.IsValid) {
            //    _CrumbList.Add(new CrumbItem("退出系统", true, true));
            //    ViewData["CrumbList"] = _CrumbList;
            //    return Page();
            //}

            HttpContext.Session.Clear();

            return RedirectToPage("Index");
        }
    }
}