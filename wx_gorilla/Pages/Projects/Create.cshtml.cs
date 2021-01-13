using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;
using Microsoft.AspNetCore.Components;

namespace com.wechat.gorilla.Pages.Projects {
    public class CreateModel :PublicPage  {
        private readonly com.wechat.gorilla.DbContexts.ProjectContext _context;

        public CreateModel(com.wechat.gorilla.DbContexts.ProjectContext context) {
            _context = context;
        }

        public IActionResult OnGet() {
            _CrumbList.Add(new CrumbItem("项目列表", "/Projects/Index"));
            _CrumbList.Add(new CrumbItem("新建项目", true, true));
            ViewData["CrumbList"] = _CrumbList;

            Provinces = _context.Province.ToList();
            return Page();
        }

        [BindProperty]
        public Project Project { get; set; }
        [BindProperty]
        public IList<Province> Provinces { get; set; }
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _context.Project.Add(Project);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        public async void ProvinceChanged(ChangeEventArgs e) {
            
        }
    }
}