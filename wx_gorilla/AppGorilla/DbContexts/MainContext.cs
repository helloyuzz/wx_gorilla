using com.wechat.gorilla.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla.DbContexts {
    public class MainContext:DbContext {
        public MainContext() : base() {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
        }
        public MainContext(DbContextOptions<MainContext> options)
             : base(options) {
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
