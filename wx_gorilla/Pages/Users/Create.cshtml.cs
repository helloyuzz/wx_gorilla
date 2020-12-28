using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;
using Microsoft.EntityFrameworkCore;

namespace com.wechat.gorilla.Pages.Users {
    public class CreateModel : PageModel {
        private readonly UserContext _context;
        private readonly DepartmentContext _ctxDepartment;
        private readonly ProjectContext _ctxProject;

        public CreateModel(com.wechat.gorilla.DbContexts.UserContext context, DepartmentContext departmentContext,ProjectContext projectContext) {
            _context = context;
            _ctxDepartment = departmentContext;
            _ctxProject = projectContext;
        }

        public async Task<IActionResult> OnGet() {
            int project_id = GorillaUtil.QueryInt(Request.Query, "id");
            if (project_id > 0) {
                Project_name = _ctxProject.Project.FirstOrDefault(A => A.ID == project_id).Project_name;
                if (User == null) {
                    User = new User();
                    User.Projectid = project_id;
                }
            } 
            DbSet<Department> dbSet = _context.Set<Department>();
            Departments = new SelectList(dbSet, "Id", "Dept_name");
            return Page();
        }

        [BindProperty]
        public User User { get; set; }
        [BindProperty]
        public string Project_name { get; set; }
        public SelectList Departments { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _context.Users.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}