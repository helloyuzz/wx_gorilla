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

namespace com.wechat.gorilla.Pages.Projects {
    public class DetailsModel : PublicPage {
        private readonly com.wechat.gorilla.DbContexts.ProjectContext _ctxProject;
        private readonly com.wechat.gorilla.DbContexts.DepartmentContext _ctxDepartment;
        private readonly com.wechat.gorilla.DbContexts.UserContext _ctxUser;

        public DetailsModel(ProjectContext context, DepartmentContext contextDepartment, UserContext ctxUser) {
            _ctxProject = context;
            _ctxDepartment = contextDepartment;
            _ctxUser = ctxUser;
        }

        public Project Project { get; set; }
        [BindProperty]
        public Province Province { get; set; }
        public City City { get; set; }
        public IList<Department> Departments { get; set; }
        public IList<User> Users { get; set; }
        [BindProperty]
        public OrgMenu MainOrgMenu { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            Project = await _ctxProject.Project.Include(A=>A.Province).Include(A=>A.City).FirstOrDefaultAsync(m => m.ID == id);

            if (Project == null) {
                return NotFound();
            }
            

            _CrumbList.Add(new CrumbItem("项目列表", "/Projects/Index"));
            _CrumbList.Add(new CrumbItem(Project.Project_name, true, true));
            ViewData["CrumbList"] = _CrumbList;


            Departments = await _ctxDepartment.Departments.Where(A => A.Projectid == Project.ID).ToListAsync();
            Users = await _ctxUser.Users.Where(A => A.Projectid == Project.ID).Include(A=>A.Project).Include(A=>A.Department).ToListAsync();
            MainOrgMenu = new OrgMenu(Project.Project_name, Project.ID.ToString(), true);
            AddSubMenus(MainOrgMenu ,- 1);
            // .Include(d=>d.Project)
            return Page();
        }

        private void AddSubMenus(OrgMenu menu, int pid) {
            var temp = Departments.Where(t => t.Parent_id == pid).ToList();
            foreach (Department department in temp) {
                OrgMenu subMenu = new OrgMenu(department.Dept_name,department.Id.ToString(),false,true);
                menu.SubMenus.Add(subMenu);
                AddSubMenus(subMenu, department.Id);
            }
        }
    }
}