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
    public class DetailsModel : PublicPage {
        private readonly com.wechat.gorilla.DbContexts.CityContext _context;

        public DetailsModel(com.wechat.gorilla.DbContexts.CityContext context) {
            _context = context;
        }

        public City City { get; set; }
        public Province Province { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            City = await _context.City.FirstOrDefaultAsync(m => m.Id == id);
            Province = await _context.Provinces.FirstOrDefaultAsync(A => A.Id == City.Provinceid);

            if (City == null) {
                return NotFound();
            }
            return Page();
        }
    }
}
