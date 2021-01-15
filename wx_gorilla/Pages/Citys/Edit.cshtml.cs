using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;

namespace com.wechat.gorilla.Pages.Citys {
    public class EditModel : PublicPage {
        private readonly com.wechat.gorilla.DbContexts.CityContext _context;

        public EditModel(com.wechat.gorilla.DbContexts.CityContext context) {
            _context = context;
        }

        [BindProperty]
        public City City { get; set; }
        [BindProperty]
        public IList<Province> Provinces { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            City = await _context.City.Include(A=>A.Province).FirstOrDefaultAsync(m => m.Id == id);
            Provinces = await _context.Provinces.ToListAsync();

            if (City == null) {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _context.Attach(City).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!CityExists(City.Id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            //return RedirectToPage("./Index");
            return RedirectToPage("/Provinces/Details", new { id = City.Provinceid });
        }

        private bool CityExists(int id) {
            return _context.City.Any(e => e.Id == id);
        }
    }
}