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
    public class DetailsModel : PublicPage {
        private readonly com.wechat.gorilla.DbContexts.UserContext _context;

        public DetailsModel(com.wechat.gorilla.DbContexts.UserContext context) {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            User = await _context.Users.Include(t=>t.Department).Include(t => t.Project).FirstOrDefaultAsync(m => m.Id == id);

            if (User == null) {
                return NotFound();
            }
            _CrumbList.Add(new CrumbItem("项目列表", "/Projects/Index"));
            _CrumbList.Add(new CrumbItem(User.Project.Project_name, "/Projects/Details?id=" + User.Projectid+"&type=1"));
            _CrumbList.Add(new CrumbItem(User.User_name, true, true));
            ViewData["CrumbList"] = _CrumbList;
            return Page();
        }
    }
}
