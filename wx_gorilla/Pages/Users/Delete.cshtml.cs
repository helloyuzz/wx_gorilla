using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;

namespace com.wechat.gorilla.Pages.Users {
    public class DeleteModel : PageModel {
        private readonly com.wechat.gorilla.DbContexts.UserContext _context;

        public DeleteModel(com.wechat.gorilla.DbContexts.UserContext context) {
            _context = context;
        }

        [BindProperty]
        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            User = await _context.Users.Include(x => x.Department).FirstOrDefaultAsync(m => m.Id == id);

            if (User == null) {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            User = await _context.Users.FindAsync(id);

            if (User != null) {
                _context.Users.Remove(User);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/Projects/Details", new { id = User.Projectid, type = 1 });
        }
    }
}