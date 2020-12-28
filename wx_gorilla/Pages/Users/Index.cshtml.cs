using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;

namespace com.wechat.gorilla.Pages.Users {
    public class IndexModel : PageModel {
        private readonly com.wechat.gorilla.DbContexts.UserContext _context;

        public IndexModel(com.wechat.gorilla.DbContexts.UserContext context) {
            _context = context;
        }

        public IList<User> User { get; set; }

        public async Task OnGetAsync() {
            User = await _context.Users.ToListAsync();
        }
    }
}