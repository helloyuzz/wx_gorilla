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
    public class DetailsModel : PublicPage {
        private readonly com.wechat.gorilla.DbContexts.AccountContext _context;

        public DetailsModel(com.wechat.gorilla.DbContexts.AccountContext context) {
            _context = context;
        }

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
    }
}