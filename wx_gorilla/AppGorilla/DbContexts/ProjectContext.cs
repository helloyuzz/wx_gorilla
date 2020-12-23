using com.wechat.gorilla.Models;
using Microsoft.EntityFrameworkCore;

namespace com.wechat.gorilla.DbContexts {
    public class ProjectContext : DbContext {
        public ProjectContext() : base() {
        }
        public ProjectContext(DbContextOptions<ProjectContext> options)
            : base(options) {
        }

        public DbSet<Project> Project { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<City> City { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
        }
    }
}
