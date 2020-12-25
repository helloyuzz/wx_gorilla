using com.wechat.gorilla.Models;
using Microsoft.EntityFrameworkCore;

namespace com.wechat.gorilla.DbContexts {
    public class CityContext:DbContext {
        public CityContext() : base() {
        }
        public CityContext(DbContextOptions<CityContext> options)
            : base(options) {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
        }

        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> City { get; set; }
        public Province province { get; set; }
    }
}
