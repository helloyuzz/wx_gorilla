using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;

namespace com.wechat.gorilla.Pages.Departments {
    public class DetailsModel : PageModel {
        private readonly com.wechat.gorilla.DbContexts.DepartmentContext _context;

        public DetailsModel(com.wechat.gorilla.DbContexts.DepartmentContext context) {
            _context = context;
        }

        public Department Department { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            Department = await _context.Department.FirstOrDefaultAsync(m => m.Id == id);
            //.Include(d => d.Project)

            if (Department == null) {
                return NotFound();
            }
            return Page();
        }
    }
}