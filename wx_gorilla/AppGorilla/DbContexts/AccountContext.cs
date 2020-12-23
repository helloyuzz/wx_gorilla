using com.wechat.gorilla.Models;
using Microsoft.EntityFrameworkCore;

namespace com.wechat.gorilla.DbContexts {
    public class AccountContext : DbContext {
        public AccountContext() : base() {
        }
        public AccountContext(DbContextOptions<AccountContext> options)
            : base(options) {
        }
        public DbSet<Account> Account { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseMySQL(Globals.MySqlConnectionString);
    }
}