using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace com.wechat.gorilla.Pages {
    public class ChangePwdModel : PublicPage {
        public void OnGet() {
            ViewData["aa"] = "aa";
            TempData["bb"] = "bb";
            ModelState.Clear();
        }
        [BindProperty(SupportsGet = true), Required, Display(Name = "µ±«∞√‹¬Î")]
        public string OldPassword { get; set; }
        [BindProperty(SupportsGet = true), Required, Display(Name = "–¬√‹¬Î")]
        public string NewPassword { get; set; }
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }            
            return RedirectToPage("/ChangePwd", new { msg = "changed" });
        }
    }
}
