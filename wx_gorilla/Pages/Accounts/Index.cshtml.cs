using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;

namespace com.wechat.gorilla.Pages.Accounts
{
    public class IndexModel : PageModel
    {
        private readonly com.wechat.gorilla.DbContexts.AccountContext _context;

        public IndexModel(com.wechat.gorilla.DbContexts.AccountContext context)
        {
            _context = context;
        }

        public IList<Account> Account { get;set; }

        public async Task OnGetAsync()
        {
            Account = await _context.Account.ToListAsync();
        }
    }
}
