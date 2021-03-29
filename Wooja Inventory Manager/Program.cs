using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wooja_Inventory_Manager.Models;
using Wooja_Inventory_Manager.Models.Context;

namespace Wooja_Inventory_Manager
{
    public class Program
    {
        public static void Main(string[] args)
        {
           

            SqliteContext databaseContext = new SqliteContext();
            databaseContext.Database.EnsureCreated();

            // Standardtabellen anlegen
            //Settings settings = new Settings() { Theme = "Wooja" };
            //databaseContext.Settings.Add(settings);
            //databaseContext.SaveChanges();

            CreateHostBuilder(args).Build().Run();
           /////////////////////////databaseContext.
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

       
       
    }
}
