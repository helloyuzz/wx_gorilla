using com.wechat.gorilla.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla.DbContexts {
    public class ProvinceContext: DbContext {
        public ProvinceContext() : base() {
        }
        public ProvinceContext(DbContextOptions<ProvinceContext> options)
            : base(options) {
        }

        public DbSet<Province> Province { get; set; }
        public DbSet<City> City { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
        }
    }
}
