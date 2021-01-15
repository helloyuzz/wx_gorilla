using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;

namespace com.wechat.gorilla.Pages.Accounts {
    public class DeleteModel : PublicPage {
        private readonly com.wechat.gorilla.DbContexts.AccountContext _context;

        public DeleteModel(com.wechat.gorilla.DbContexts.AccountContext context) {
            _context = context;
        }

        [BindProperty]
        public Account Account { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            Account = await _context.Account.FirstOrDefaultAsync(m => m.Id == id);

            if (Account == null) {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            Account = await _context.Account.FindAsync(id);

            if (Account != null) {
                _context.Account.Remove(Account);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}