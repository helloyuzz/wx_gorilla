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

namespace com.wechat.gorilla.Pages.Departments {
    public class EditModel : PageModel {
        private readonly DepartmentContext _ctxDepartment;
        private readonly ProjectContext _ctxProject;

        public EditModel(DepartmentContext context, ProjectContext ctxProject) {
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
            // .Include(d => d.Project)

            if (Department == null) {
                return NotFound();
            }
            Project_name = _ctxProject.Project.FirstOrDefault(A => A.ID == Department.Projectid).Project_name;
            
            //ViewData["Projectid"] = new SelectList(_context.Set<Project>(), "ID", "Project_name");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _ctxDepartment.Attach(Department).State = EntityState.Modified;

            try {
                await _ctxDepartment.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!DepartmentExists(Department.Id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            //return RedirectToPage("./Index");
            return RedirectToPage("/Projects/Details", new { id = Department.Projectid });
        }

        private bool DepartmentExists(int id) {
            return _ctxDepartment.Departments.Any(e => e.Id == id);
        }
    }
}