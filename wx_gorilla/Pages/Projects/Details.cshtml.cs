using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;

namespace com.wechat.gorilla.Pages.Projects {
    public class DetailsModel : PageModel {
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

        public async Task<IActionResult> OnGetAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            Project = await _ctxProject.Project.Include(A=>A.Province).Include(A=>A.City).FirstOrDefaultAsync(m => m.ID == id);

            if (Project == null) {
                return NotFound();
            }

            Departments = await _ctxDepartment.Departments.Where(A => A.Projectid == Project.ID).ToListAsync();
            Users = await _ctxUser.Users.Where(A => A.Projectid == Project.ID).Include(A=>A.Project).Include(A=>A.Department).ToListAsync();
            // .Include(d=>d.Project)
            return Page();
        }
    }
}