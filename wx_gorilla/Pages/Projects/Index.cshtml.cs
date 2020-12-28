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

        public async Task<IActionResult> OnGet() {
            User user = HttpContext.Session.Get<User>(Globals.KEY_CUA);
            if (user == null) {
                return RedirectToPage("Login");
            }

            HtmlTip = "";
            IQueryable<Project> temp = _context.Project.Include(A => A.Province).Include(B => B.City);
            if (string.IsNullOrEmpty(SearchProvince) == false) {
                temp = temp.Where(A => A.Province.Province_name.Contains(SearchProvince));
                HtmlTip = SearchProvince;
            }
            if (string.IsNullOrEmpty(SearchProjectName) == false) {
                temp = temp.Where(A => A.Project_name.Contains(SearchProjectName));
                HtmlTip += "名称包括\"" + SearchProjectName + "\"的";
            }
            if (string.IsNullOrEmpty(SearchProgress) == false) {
                temp = temp.Where(A => A.Current_progress == SearchProgress);
                HtmlTip +=  SearchProgress;
            }
            if (string.IsNullOrEmpty(HtmlTip)) {
                HtmlTip = "所有";
            }
            Project = await temp.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToListAsync();
            RecordCount = temp.Count();
            //if (string.IsNullOrEmpty(SearchProjectName) && string.IsNullOrEmpty(SearchProvince) && string.IsNullOrEmpty(SearchProgress)) {
            //    Project = await _context.Project.Include(A => A.Province).Include(B => B.City).Skip((PageIndex - 1) * PageSize).Take(PageSize).ToListAsync();
            //    RecordCount = _context.Project.Count();
            //} else if (string.IsNullOrEmpty(SearchProjectName)) {
            //    if (string.IsNullOrEmpty(SearchProvince)) {
            //        Project = await _context.Project.Where(s => s.Project_name.Contains(SearchProjectName)).Include(A => A.Province).Include(B => B.City).Skip((PageIndex - 1) * PageSize).Take(PageSize).ToListAsync();
            //        RecordCount = _context.Project.Where(s => s.Project_name.Contains(SearchProjectName)).Count();
            //    } else {
            //    }
            //}
            PageCount = RecordCount / PageSize;
            if (RecordCount % PageSize > 0) {
                PageCount++;
            }
            return Page();
        }
        [BindProperty(SupportsGet = true)]
        public string SearchProjectName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchProvince { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchProgress { get; set; }
        [BindProperty(SupportsGet = true)]
        public int PageSize { get; set; } = 12;
        [BindProperty(SupportsGet = true)]
        public int PageIndex { get; set; } = 1;
        [BindProperty(SupportsGet = true)]
        public int PageCount { get; set; }
        [BindProperty(SupportsGet = true)]
        public int RecordCount { get; set; }
        [BindProperty(SupportsGet =true)]
        public string HtmlTip { get; set; }
    }
}