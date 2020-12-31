using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using com.wechat.gorilla;
using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace com.wechat.gorilla.Pages {
    public class LoginModel : PageModel {
        private readonly com.wechat.gorilla.DbContexts.UserContext _userContext;
        private User User { get; set; }

        
        public string tipDisplayed = "none";
        public LoginModel(UserContext userContext) {
            _userContext = userContext;
        }

        public IActionResult OnGet() {
            ModelState.Clear();
            bool isWrongAccountOrPwd = Request.Query.ContainsKey("id");
            if (isWrongAccountOrPwd) {
                tipDisplayed = "block";
            }
             return Page();
        }
        [BindProperty(SupportsGet = true), Required(ErrorMessage ="帐号不能为空"), Display(Name = "帐号")]
        public string Account { get; set; }
        [BindProperty(SupportsGet = true), Required(ErrorMessage ="密码不能为空"), Display(Name = "密码")]
        public string Password { get; set; }
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            //string account = Request.Form["uac_account"];
            //string pwd = Request.Form["uac_pwd"];
            string pwd_encrypt = GorillaUtil.Md5(Password);

            User = _userContext.Users.FirstOrDefault(A => A.User_account.Equals(Account) && A.User_password.Equals(pwd_encrypt));
            if (User != null) {
                HttpContext.Session.Set(Globals.SessionKey_CUA, User);

                User.Login_time = DateTime.Now;
                _userContext.Users.Attach(User).Property(x => x.Login_time).IsModified = true;
                _userContext.SaveChanges();

                Globals.Current_user = User;
                return RedirectToPage("Index");
            } else {
                return RedirectToPage("Login",new { id=DateTime.Now.ToString("yyyymmddHHmmssfff") });
            }
            //return Page();
        }
    }
}
