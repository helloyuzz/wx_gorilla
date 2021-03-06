﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;

namespace com.wechat.gorilla.Pages.Departments {
    public class DeleteModel : PublicPage {
        private readonly DepartmentContext _ctxDepartment;
        private readonly ProjectContext _ctxProject;

        public DeleteModel(DepartmentContext context, ProjectContext ctxProject) {
            _ctxDepartment = context;
            _ctxProject = ctxProject;
        }

        [BindProperty]
        public Department Department { get; set; }
        [BindProperty]
        public string Project_name { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            Department = await _ctxDepartment.Departments.FirstOrDefaultAsync(m => m.Id == id);
            //    .Include(d => d.Project)

            if (Department == null) {
                return NotFound();
            }
            Project_name = _ctxProject.Project.FirstOrDefault(A => A.ID == Department.Projectid).Project_name;

            _CrumbList.Add(new CrumbItem("项目列表", "/Projects/Index"));
            _CrumbList.Add(new CrumbItem(Project_name, true, true));
            ViewData["CrumbList"] = _CrumbList;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            Department = await _ctxDepartment.Departments.FindAsync(id);

            if (Department != null) {
                _ctxDepartment.Departments.Remove(Department);
                await _ctxDepartment.SaveChangesAsync();
            }

            //return RedirectToPage("./Index");
            return RedirectToPage("/Projects/Details", new { id = Department.Projectid });
        }
    }
}