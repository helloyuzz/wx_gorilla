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
    public class IndexModel : PageModel {
        private readonly com.wechat.gorilla.DbContexts.ProjectContext _context;

        public IndexModel(com.wechat.gorilla.DbContexts.ProjectContext context) {
            _context = context;
        }

        public IList<Project> Project { get; set; }

        public async Task OnGetAsync() {
            if (string.IsNullOrEmpty(SearchString)) {
                Project = await _context.Project.ToListAsync();
            } else {
                Project = await _context.Project.Where(s => s.Project_name.Contains(SearchString)).ToListAsync();
            }
        }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

    }
}