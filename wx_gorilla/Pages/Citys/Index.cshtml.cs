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
    public class IndexModel : PageModel {
        private readonly com.wechat.gorilla.DbContexts.CityContext _context;

        public IndexModel(com.wechat.gorilla.DbContexts.CityContext context) {
            _context = context;
        }

        public IList<City> City { get; set; }

        public async Task OnGetAsync() {
            City = await _context.City.OrderBy(A=>A.Show_index).ToListAsync();
        }
    }
}