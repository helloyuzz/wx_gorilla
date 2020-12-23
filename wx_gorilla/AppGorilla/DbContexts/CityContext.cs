using com.wechat.gorilla.Models;
using Microsoft.EntityFrameworkCore;

namespace com.wechat.gorilla.DbContexts {
    public class CityContext:DbContext {
        public CityContext() : base() {
        }
        public CityContext(DbContextOptions<CityContext> options)
            : base(options) {
        }

        public DbSet<Province> Province { get; set; }
        public DbSet<City> City { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
        }
    }
}
