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
    public class CreateModel : PublicPage {
        private readonly UserContext _context;
        private readonly DepartmentContext _ctxDepartment;
        private readonly ProjectContext _ctxProject;
        [BindProperty]
        public int Project_id { get; set; }
        [BindProperty]
        public User User { get; set; }
        [BindProperty]
        public string Project_name { get; set; }
        public SelectList Departments { get; set; }

        public CreateModel(com.wechat.gorilla.DbContexts.UserContext context, DepartmentContext departmentContext,ProjectContext projectContext) {
            _context = context;
            _ctxDepartment = departmentContext;
            _ctxProject = projectContext;
        }

        public async Task<IActionResult> OnGet() {
            ViewType = Request.Query["type"];
            FromPage = Request.Headers["Referer"].ToString();
            Project_id = GorillaUtil.QueryInt(Request.Query, "id");
            if (Project_id > 0) {
                Project_name = _ctxProject.Project.FirstOrDefault(A => A.ID == Project_id).Project_name;
                if (User == null) {
                    User = new User();
                    User.Projectid = Project_id;
                }
            }
            List<Department> dbSet = null;

            switch (ViewType) {
                case "User":    // 科室帐号
                    _CrumbList.Add(new CrumbItem("项目列表", "/Projects/Index"));
                    _CrumbList.Add(new CrumbItem(Project_name));
                    dbSet = _context.Set<Department>().Where(a => a.Projectid == Project_id).ToList();
                    break;
                case "Employee":    // 员工帐号
                    _CrumbList.Add(new CrumbItem("用户管理", "/Users/Index"));
                    _CrumbList.Add(new CrumbItem("新建人员帐号"));
                    dbSet = new List<Department>();
                    Department department = new Department() {
                        Id = -1,
                        Dept_name = "公司帐号"
                    };
                    dbSet.Add(department);
                    break;
            }
            Departments = new SelectList(dbSet, "Id", "Dept_name");
            return Page();
        }


        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _context.Users.Add(User);
            await _context.SaveChangesAsync();

            return Redirect(FromPage);
            //return RedirectToPage("/Projects/Details", new { id = User.Projectid ,type=1});
        }
    }
}