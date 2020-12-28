using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.wechat.gorilla.Models;

namespace com.wechat.gorilla.DbContexts {
    public class DepartmentContext:DbContext {
        public DepartmentContext() : base() {
        }
        public DepartmentContext(DbContextOptions<DepartmentContext> options)
            : base(options) {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
        }
        public DbSet<com.wechat.gorilla.Models.Department> Departments { get; set; }
        public Project Project { get; set; }
    }
}
