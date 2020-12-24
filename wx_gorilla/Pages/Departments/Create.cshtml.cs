﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;

namespace com.wechat.gorilla.Pages.Departments
{
    public class CreateModel : PageModel
    {
        private readonly com.wechat.gorilla.DbContexts.DepartmentContext _context;

        public CreateModel(com.wechat.gorilla.DbContexts.DepartmentContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["Projectid"] = new SelectList(_context.Set<Project>(), "ID", "Project_name");
            return Page();
        }

        [BindProperty]
        public Department Department { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Department.Add(Department);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
