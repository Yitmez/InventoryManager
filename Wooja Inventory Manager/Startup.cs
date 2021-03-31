using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wooja_Inventory_Manager.Interfaces;
using Wooja_Inventory_Manager.Middleware;
using Wooja_Inventory_Manager.Models;
using Wooja_Inventory_Manager.Models.Context;
using Wooja_Inventory_Manager.Services;

namespace Wooja_Inventory_Manager
{
    public class Startup
    {


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddControllersWithViews();
            services.AddSingleton<IItemGenerator, Item>(); ///////////////////////////////
                                                           // services.AddSingleton<IDBSelecter, DBSelecter>();
                                                           //Über DI DBs unterscheiden
                                                           //string selectedDatabase = Configuration["DataBase"];
                                                           //Console.WriteLine (selectedDatabase);

            //services.AddDbContext<SqliteContext>(options =>
            //options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));

            //services.AddSingleton<IDBSelecter>(serviceProvider =>
            //{
            services.AddDbContext<SQLServerContext>(opts => {
                opts.UseSqlServer(Configuration["ConnectionStrings:WIMConnection"]);
            });

            string selectedDatabase = Configuration["DataBase"];
            //    return (IDBSelecter)ActivatorUtilities.CreateInstance(serviceProvider, selectedDatabase == null ?
            //        )
            //})
            //services.AddSingleton<Services.MathService>();

            IResponseFormatter formatter = new TextResponseFormatter();
            //app.Use(async (context, next) =>
            //{
            //    if (context.Request.Path == "/middleware/function")
            //    {
            //        await formatter.Format(context, 
            //            "Middleware Function: It is snowing in Chicago");

            //    } else
            //    {
            //        await next();
            //    }
            //});

            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(1);
                options.Cookie.IsEssential = true;
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            app.UseHsts();  // in Zukunft nur noch htttps möglich

            // app.UseHttpsRedirection();   // https erzwingen / umleiten  (wenn app.UseHsts(); unnötig. ?
            // Cockies
            app.UseCookiePolicy();  // vom System...
            app.UseMiddleware<ConsentMiddleware>();

            // Ende Cookies

            // Session - Serverseitiges speichern
            app.UseSession();   // 
            // Ende Session 

            //app.Run(MyMiddleware(2, 4);

            //public async Task MyMiddleware() // HttpContext context
            //{
            //    await Services.MathService(int x, int y);
            //}
            // app.Run(MyMiddleware(2, 4));

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");


                endpoints.MapControllerRoute(
                    name: "items",
                    pattern: "{controller=Items}/{action=Index}/{id?}");

                endpoints.MapGet("/cookie", async context =>
                {
                    int counter1 = int.Parse(context.Request.Cookies["counter1"] ?? "0") + 1;
                    context.Response.Cookies.Append("counter1", counter1.ToString(), new CookieOptions
                    {
                        MaxAge = TimeSpan.FromMinutes(30),
                        IsEssential = true

                    });

                //    string privacyIsOk = context.Request.Cookies["OK"] ?? "0") + 1;
                //context.Response.Cookies.Append("privacyIsOk", privacyIsOk.ToString(), new CookieOptions
                //{
                //    MaxAge = TimeSpan.FromMinutes(30),
                //    IsEssential = true

                //});




                    //string wsId = Configuration["WebService:Key"];
                    //string wskey = Configuration["WebService:Id"];
                    //await context.Response.WriteAsync($"The Webservice:Key is {wsKey}\n");

                    //await context.Response.WriteAsync($"The Webservice:Id is {wsId}\n");
                });




                //endpoints.MapGet("/", async context =>
                //{
                //    IResponseFormatter formatter = context.RequestServices
                //    .GetServices<IResponseFormatter>().First(f => f.RichOutput);
                //    await formatter.Format(context, "2ndDB");


                //});
                // }

                //private RequestDelegate MyMiddleware(int v1, int v2)
                //{
                //    // throw new NotImplementedException();
                //    return Services.MathService(2, 3);
                //}
            });

        }
    }
}
