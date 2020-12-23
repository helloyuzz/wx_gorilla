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
    public class DetailsModel : PageModel {
        private readonly com.wechat.gorilla.DbContexts.ProvinceContext _context;

        public DetailsModel(com.wechat.gorilla.DbContexts.ProvinceContext context) {
            _context = context;
        }

        public Province Province { get; set; }
        public IList<City> Citys { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            Province = await _context.Province.FirstOrDefaultAsync(m => m.Id == id);
            Citys = await _context.City.Where(A => A.fk_province_id == id).OrderBy(B=>B.Show_index).ToListAsync();

            if (Province == null) {
                return NotFound();
            }
            return Page();
        }
    }
}