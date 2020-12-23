using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace com.wechat.gorilla.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase {
        private AccountContext accountContext;
        public AccountController(AccountContext accountContext) {
            this.accountContext = accountContext;
        }
        [HttpGet]
        public IList<Account> Get() {
            IList<Account> result = new List<Account>();
            result = accountContext.Account.ToList();

            
            return result;
            //return smProjectContext.SmProject.ToList();
        }
    }
}
