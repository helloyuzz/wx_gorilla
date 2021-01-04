using com.wechat.gorilla.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla.DbContexts {
    public class EmployeeContext : DbContext {
        public EmployeeContext() : base() {
        }
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options) {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
        }

        public DbSet<Employee> Employees { get; set; }
        public Employee Employee { get; set; }
    }
}