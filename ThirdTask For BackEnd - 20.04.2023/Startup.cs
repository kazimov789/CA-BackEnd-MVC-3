using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThirdTask_For_BackEnd___20._04._2023.DataAccess;

namespace ThirdTask_For_BackEnd___20._04._2023
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlServer("Server=LAPTOP-DMGD9EDH\\SQLEXPRESS;DataBase=ThirdTaskProject;Trusted_Connection=true");
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute
                (
                    "default",
                    "{controller=home}/{action=index}/{id?}"
                );
                endpoints.MapControllerRoute
                (
                    "about",
                    "about-us",
                    defaults: new { controller = "home", action = "about" }
                );
                endpoints.MapControllerRoute
                (
                    "contact",
                    "contact-us",
                    defaults: new { controller = "home", action = "contact" }
                );
            });
        }
    }
}
