using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;

namespace com.wechat.gorilla.Pages.Citys {
    public class CreateModel : PageModel {
        private readonly com.wechat.gorilla.DbContexts.CityContext _context;

        public CreateModel(com.wechat.gorilla.DbContexts.CityContext context) {
            _context = context;
        }

        public IActionResult OnGet() {
            Province = _context.Province.ToList();
            return Page();
        }

        [BindProperty]
        public City City { get; set; }
        [BindProperty]
        public IList<Province> Province { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _context.City.Add(City);
            await _context.SaveChangesAsync();

            //return RedirectToPage("./Index");

            return RedirectToPage("/Provinces/Details", new { id = City.fk_province_id });
        }
    }
}