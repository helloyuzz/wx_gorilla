using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;

namespace com.wechat.gorilla.Pages.Provinces {
    public class DeleteModel : PageModel {
        private readonly com.wechat.gorilla.DbContexts.ProvinceContext _context;

        public DeleteModel(com.wechat.gorilla.DbContexts.ProvinceContext context) {
            _context = context;
        }

        [BindProperty]
        public Province Province { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            Province = await _context.Province.FirstOrDefaultAsync(m => m.Id == id);

            if (Province == null) {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            Province = await _context.Province.FindAsync(id);

            if (Province != null) {
                _context.Province.Remove(Province);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}