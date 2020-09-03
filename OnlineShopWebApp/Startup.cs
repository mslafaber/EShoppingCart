using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //below service adds controllers to the specified Iservices collection above and enables to use MVC pattern for controllers models and views in this project
            services.AddControllersWithViews();

            //add own custom services as below
            //Register interfaces with the corresponding repository that implements it.
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IItemRepository, ItemRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //used to add middleware that is used to applucation to run
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //this page allows error messages during the development of the project
                app.UseDeveloperExceptionPage();
            }
            //Https middleware is added
            app.UseHttpsRedirection();
            //will automarically search a directory in the app called wwwroot for all staticfiles default
            app.UseStaticFiles();

            //enable mvc to respond
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //map to a controller and an action in the controller and pass optional ID parameter
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{Controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
