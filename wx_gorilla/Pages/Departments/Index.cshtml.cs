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
    public class IndexModel : PageModel {
        private readonly com.wechat.gorilla.DbContexts.DepartmentContext _context;

        public IndexModel(com.wechat.gorilla.DbContexts.DepartmentContext context) {
            _context = context;
        }

        public IList<Department> Department { get; set; }
        public Project Project { get; set; }

        public async Task OnGetAsync() {
            Department = await _context.Department
                .Include(d => d.Project).ToListAsync();
        }
    }
}