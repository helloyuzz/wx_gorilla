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

namespace com.wechat.gorilla.Pages.Projects {
    public class EditModel : PageModel {
        private readonly com.wechat.gorilla.DbContexts.ProjectContext _context;

        public EditModel(com.wechat.gorilla.DbContexts.ProjectContext context) {
            _context = context;
        }

        [BindProperty]
        public Project Project { get; set; }
        [BindProperty]
        public IList<Province> Provinces { get; set; }
        [BindProperty]
        public string FromSource { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            FromSource = Request.Query["source"];
            Provinces = _context.Province.ToList();
            Project = await _context.Project.FirstOrDefaultAsync(m => m.ID == id);

            if (Project == null) {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _context.Attach(Project).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!ProjectExists(Project.ID)) {
                    return NotFound();
                } else {
                    throw;
                }
            }
            if (FromSource.Equals("index")) {
                return RedirectToPage("./Index");
            } else {
                return RedirectToPage("./Details", new { id = Project.ID });
            }

        }

        private bool ProjectExists(int id) {
            return _context.Project.Any(e => e.ID == id);
        }
    }
}