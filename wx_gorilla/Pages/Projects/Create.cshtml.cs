﻿using System;
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
    public class CreateModel : PageModel {
        private readonly com.wechat.gorilla.DbContexts.ProjectContext _context;

        public CreateModel(com.wechat.gorilla.DbContexts.ProjectContext context) {
            _context = context;
        }

        public IActionResult OnGet() {
            Provinces = _context.Province.ToList();
            if (Fk_Province_Id > 0) {
                Citys = _context.City.Where(A => A.fk_province_id == Fk_Province_Id).ToList();
            }
            if (Citys == null) {
                Citys = new List<City>();
            }
            return Page();
        }

        [BindProperty]
        public Project Project { get; set; }
        [BindProperty]
        public IList<Province> Provinces { get; set; }
        [BindProperty]
        public IList<City> Citys { get; set; }
        [BindProperty(SupportsGet =true)]
        public int Fk_Province_Id { get; set; }

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