using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;
using com.wechat.gorilla.Menus;

namespace com.wechat.gorilla.Pages.Users {
    public class IndexModel : PublicPage {
        private readonly com.wechat.gorilla.DbContexts.UserContext _context;

        public IndexModel(com.wechat.gorilla.DbContexts.UserContext context) {
            _context = context;
        }

        public IList<User> User { get; set; }
        [BindProperty]
        public OrgMenu OrgMenuItem { get; set; }

        public async Task OnGetAsync() {
            _CrumbList.Add(new CrumbItem("用户管理"));
            ViewType = Request.Query["type"];
            if (string.IsNullOrEmpty(ViewType) == false) {
                User = await _context.Users.Where(x=>x.User_type.Equals(ViewType)).ToListAsync();
            } else {
            User = await _context.Users.ToListAsync();
            }
        }
    }
}