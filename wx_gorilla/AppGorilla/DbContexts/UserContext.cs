using com.wechat.gorilla.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla.DbContexts {
    public class UserContext:DbContext {
        public UserContext() : base() {
        }
        public UserContext(DbContextOptions<UserContext> options)
            : base(options) {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
        }
        public DbSet<User> Users { get; set; }
        public User User { get; set; }
    }
}
