using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace com.wechat.gorilla.Pages {
    public class HidePanelPageModel : PublicPage {
        public string ThemeUrl = "";
        public string SwitchPanel = "";
        public string ActiveMenuId = "";
        private readonly UserContext _userContext;
        public HidePanelPageModel(UserContext userContext) {
            _userContext = userContext;
        }
        public void OnGet() {
            SwitchPanel = Request.Query["showPanel"];
            ActiveMenuId = Request.Query["activeMenuId"];
            ThemeUrl = Request.Query["themeUrl"];

            if (string.IsNullOrEmpty(SwitchPanel) == false) {
                //HttpContext.Session.Set(SessionExtensions.SessionKey_SwitchPanel, SwitchPanel);
                //SwitchPanel = HttpContext.Session.Get<string>(SessionExtensions.SessionKey_SwitchPanel);
                SessionExtensions.Set<string>(HttpContext.Session, SessionExtensions.SessionKey_SwitchPanel, SwitchPanel);
                SwitchPanel = SessionExtensions.Get<string>(HttpContext.Session, SessionExtensions.SessionKey_SwitchPanel);
            } else {
                SwitchPanel = "null";
            }

            if (string.IsNullOrEmpty(ActiveMenuId) == false) {
                //HttpContext.Session.Set(SessionExtensions.SessionKey_ActiveMenuId, ActiveMenuId);
                //ActiveMenuId = HttpContext.Session.Get<string>(SessionExtensions.SessionKey_ActiveMenuId);
                //SessionExtensions.Set<string>(HttpContext.Session, SessionExtensions.SessionKey_ActiveMenuId, ActiveMenuId);
                ActiveMenuId = SessionExtensions.Get<string>(HttpContext.Session, SessionExtensions.SessionKey_ActiveMenuId);
            } else {
                ActiveMenuId = "null";
            }

            if (string.IsNullOrEmpty(ThemeUrl) == false) {
                User user = SessionExtensions.Get<User>(HttpContext.Session, SessionExtensions.SessionKey_CUA);
                if (user != null) {
                    if (user.Theme_url.Equals(ThemeUrl) == false) {
                        user.Theme_url = ThemeUrl;
                        _userContext.Users.Attach(user).Property(x => x.Theme_url).IsModified = true;
                        _userContext.SaveChanges();

                        SessionExtensions.Set<User>(HttpContext.Session, SessionExtensions.SessionKey_CUA, user);
                    }
                    Console.WriteLine(user.Id);
                }
            }
        }
        public async Task<IActionResult> OnPostAsync() {
            return RedirectToPage("./Index");
        }
    }
}
