using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;
using Microsoft.EntityFrameworkCore;

namespace com.wechat.gorilla.Pages.Citys {
    public class CreateModel : PublicPage {
        private readonly com.wechat.gorilla.DbContexts.CityContext _context;

        public CreateModel(com.wechat.gorilla.DbContexts.CityContext context) {
            _context = context;
        }

        public IActionResult OnGet() {
            Province = _context.Provinces.ToList();
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
            string[] citys = City.City_name.Split(' ');
            if (citys.Length > 1) {
                List<City> dbSet = new List<City>();
                int showIndex = City.Show_index.Value;
                foreach (string temp in citys) {
                    City newCity = new City();
                    newCity.Provinceid = City.Provinceid;
                    newCity.City_name = temp;
                    newCity.Show_index = showIndex++;
                    dbSet.Add(newCity);
                }
                _context.City.AddRange(dbSet);
            } else {
                _context.City.Add(City);
            }
            await _context.SaveChangesAsync();

            //return RedirectToPage("./Index");

            return RedirectToPage("/Provinces/Details", new { id = City.Provinceid });
        }
    }
}