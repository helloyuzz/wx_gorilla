using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;

namespace com.wechat.gorilla.Pages.Departments {
    public class CreateModel : PublicPage {
        private readonly com.wechat.gorilla.DbContexts.DepartmentContext _ctxDepartment;
        private readonly ProjectContext _ctxProject;

        public CreateModel(DepartmentContext context, ProjectContext ctxProject) {
            _ctxDepartment = context;
            _ctxProject = ctxProject;
        }

        public IActionResult OnGet() {
            int project_id = GorillaUtil.QueryInt(Request.Query, "id");
            int error_code = GorillaUtil.QueryInt(Request.Query, "error_code");
            if (project_id > 0) {
                Project_name = _ctxProject.Project.FirstOrDefault(A => A.ID == project_id).Project_name;
            }

            if (error_code > 0) {
                Error_msg = ErrorCode.ParseCode(error_code).Msg;
            }

            _CrumbList.Add(new CrumbItem("项目列表", "/Projects/Index"));
            _CrumbList.Add(new CrumbItem(Project_name, true, true));
            ViewData["CrumbList"] = _CrumbList;

            if (Department == null) {
                Department = new Department();
                Department.Projectid = project_id;
            }
            //ViewData["Projectid"] = new SelectList(_ctxDepartment.Set<Project>(), "ID", "Project_name");
            return Page();
        }

        [BindProperty]
        public Department Department { get; set; }
        [BindProperty]
        public string Project_name { get; set; }
        [BindProperty]
        public string Error_msg { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                var msg = string.Empty;
                foreach (var value in ModelState.Values) {
                    if (value.Errors.Count > 0) {
                        foreach (var error in value.Errors) {
                            msg = msg + error.ErrorMessage;
                        }
                    }
                }
                Console.WriteLine(msg);
                return Page();
            }

            int count = _ctxDepartment.Departments.Count(A => A.Dept_name.Equals(Department.Dept_name));
            if (count > 0) {
                return RedirectToPage("/Departments/Create", new { id = Department.Projectid,error_code= ErrorCode.Error_DepartmentAlreadyExist.Code });
            } else {
                _ctxDepartment.Departments.Add(Department);
                await _ctxDepartment.SaveChangesAsync();

                //return RedirectToPage("./Index");
                return RedirectToPage("/Projects/Details", new { id = Department.Projectid });
            }
        }
    }
}