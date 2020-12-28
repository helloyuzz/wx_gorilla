using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using com.wechat.gorilla;
using com.wechat.gorilla.DbContexts;
using System;

namespace wx_razor_project {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddRazorPages();
            services.AddControllers();
            services.AddSession(a => a.IdleTimeout = TimeSpan.FromMinutes(30));

            //services.AddDbContext<MovieContext>(options =>
            //        options.UseSqlServer(Configuration.GetConnectionString("MsSql")));
            services.AddDbContext<AccountContext>(a => a.UseMySQL(Globals.MySqlConnectionString));
            services.AddDbContext<ProjectContext>(a => a.UseMySQL(Globals.MySqlConnectionString));
            services.AddDbContext<ProvinceContext>(a => a.UseMySQL(Globals.MySqlConnectionString));
            services.AddDbContext<CityContext>(a => a.UseMySQL(Globals.MySqlConnectionString));
            services.AddDbContext<DepartmentContext>(a => a.UseMySQL(Globals.MySqlConnectionString));
            services.AddDbContext<UserContext>(a => a.UseMySQL(Globals.MySqlConnectionString));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            } else {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapRazorPages();
            });
            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
