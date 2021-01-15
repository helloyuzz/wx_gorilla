using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;

namespace com.wechat.gorilla.Pages.Citys {
    public class DeleteModel : PublicPage {
        private readonly com.wechat.gorilla.DbContexts.CityContext _context;

        public DeleteModel(com.wechat.gorilla.DbContexts.CityContext context) {
            _context = context;
        }

        [BindProperty]
        public City City { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            City = await _context.City.Include(x => x.Province).FirstOrDefaultAsync(m => m.Id == id);

            if (City == null) {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            City = await _context.City.FindAsync(id);

            if (City != null) {
                _context.City.Remove(City);
                await _context.SaveChangesAsync();
            }

            //return RedirectToPage("./Index");
            return RedirectToPage("/Provinces/Details", new { id = City.Provinceid });
        }
    }
}