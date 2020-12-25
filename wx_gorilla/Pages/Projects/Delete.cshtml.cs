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
    public class DeleteModel : PageModel {
        private readonly com.wechat.gorilla.DbContexts.ProjectContext _context;

        public DeleteModel(com.wechat.gorilla.DbContexts.ProjectContext context) {
            _context = context;
        }

        [BindProperty]
        public Project Project { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            Project = await _context.Project.Include(A=>A.Province).Include(A=>A.City).FirstOrDefaultAsync(m => m.ID == id);

            if (Project == null) {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            Project = await _context.Project.FindAsync(id);

            if (Project != null) {
                _context.Project.Remove(Project);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}