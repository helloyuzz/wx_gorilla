using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;

namespace com.wechat.gorilla.Pages.Employees {
    public class IndexModel : PageModel {
        private readonly com.wechat.gorilla.DbContexts.EmployeeContext _context;

        public IndexModel(com.wechat.gorilla.DbContexts.EmployeeContext context) {
            _context = context;
        }

        public IList<Employee> Employee { get; set; }

        public async Task OnGetAsync() {
            Employee = await _context.Employees
                .Include(e => e.Department).ToListAsync();
        }
    }
}