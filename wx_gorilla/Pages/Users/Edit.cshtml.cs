using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;

namespace com.wechat.gorilla.Pages.Users {
    public class EditModel : PublicPage {
        private readonly com.wechat.gorilla.DbContexts.MainContext _ctx;

        public EditModel(com.wechat.gorilla.DbContexts.MainContext context) {
            _ctx = context;
        }

        [BindProperty]
        public User User { get; set; }
        public SelectList Departments { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id,int? deptid,int? projectid) {
            if (id == null) {
                return NotFound();
            }

            User = await _ctx.Users.Include(x=>x.Department).FirstOrDefaultAsync(m => m.Id == id);

            if (User == null) {
                return NotFound();
            }
            string project_name = "";
            if (projectid != null) {
                project_name = _ctx.Projects.FirstOrDefault(p => p.ID == projectid.Value).Project_name;
            }

            _CrumbList.Add(new CrumbItem("项目列表", "/Projects/Index"));
            _CrumbList.Add(new CrumbItem(project_name, true, true));
            _CrumbList.Add(new CrumbItem(User.Department.Dept_name, true, true));
            ViewData["CrumbList"] = _CrumbList;

            List<Department> dbSet = _ctx.Set<Department>().Where(a => a.Projectid == projectid.Value).ToList();
            Departments = new SelectList(dbSet, "Id", "Dept_name");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _ctx.Attach(User).State = EntityState.Modified;

            try {
                await _ctx.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!UserExists(User.Id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return RedirectToPage("/Projects/Details",new { id=User.Projectid,type=1});
        }

        private bool UserExists(int id) {
            return _ctx.Users.Any(e => e.Id == id);
        }
    }
}