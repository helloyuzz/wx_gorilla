using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace com.wechat.gorilla.Pages {
    public class HidePanelPageModel : PageModel {
        public string SwitchPanel = "";
        public void OnGet() {
            SwitchPanel = Request.Query["showPanel"];
            if (string.IsNullOrEmpty(SwitchPanel) == false) {
                HttpContext.Session.Set(Globals.SessionKey_SwitchPanel, SwitchPanel);
                SwitchPanel = HttpContext.Session.Get<string>(Globals.SessionKey_SwitchPanel);
            } else {
                SwitchPanel = "null";
            }
        }
        public async Task<IActionResult> OnPostAsync() {
            return RedirectToPage("./Index");
        }
    }
}
