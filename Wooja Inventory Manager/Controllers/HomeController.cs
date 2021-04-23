﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Wooja_Inventory_Manager.Models;
using Wooja_Inventory_Manager.Models.Context;
using Wooja_Inventory_Manager.Services;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Wooja_Inventory_Manager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       

        public HomeController(ILogger<HomeController> logger, WIMContext context) // ,  IDBSelecter selecter
        {
            this.Context = context;
            _logger = logger;
           // Context = selecter.GetCurrentDBContext();
            //Context = new DBSelecter().GetCurrentDBContext();  //selector.GetCurrentDBContext();
        }


        WIMContext Context;


        public IActionResult Index()
        {

            // Hier Cockieabfrage einbauen ???

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Settings() //int id
        {
            //  sqliteContext.Settings.Find   //   die Felder mit aktuellen Werten in die settings... danach weitergeben
            var settings = await Context.Settings
                .AsNoTracking()
                .FirstOrDefaultAsync(i => i.Id == 1);
           
            //Settings settings = new Settings();

            return View(settings);
        }
            
        [HttpPost]
        public async Task<IActionResult> Settings(string theme, string companyName, string db, string logoPath, string version, 
            int tax, string language, string server, string port, int year, string conString, string dbPw, string licenceType,
            string licenceChecked, bool labelOn)

          

        {
            Settings settings;

            if (ModelState.GetValidationState(nameof(settings.CompanyName)) == ModelValidationState.Valid && companyName == "")
            {
                ModelState.AddModelError(nameof(settings.CompanyName), "Enter a company name");
            }

            if (ModelState.GetValidationState(nameof(settings.MwSt)) == ModelValidationState.Valid && tax < 1)
            {
                ModelState.AddModelError(nameof(settings.MwSt), "Enter a positive Number");
            }


            // if(sqliteContext..Settings)
         
            try
            {
                settings = await Context.Settings
                         .AsNoTracking()
                         .FirstOrDefaultAsync(i => i.Id == 1);
                settings.Theme = theme;
                settings.CompanyName = companyName;
                settings.Version = version;
                settings.DB = db;
                settings.Logo = logoPath;
                settings.PW = dbPw;
                settings.LicenceType = licenceType;
                settings.LicenceChecked = licenceChecked;
                //Configuration[]   // in die Configurationsdatei schreiben -> wie??
                settings.Language = language;
                settings.DateYear = year;
                settings.DB = db;
                settings.Server = server;
                settings.ConString = conString;
                settings.Port = port;
                settings.MwSt = tax;
                settings.LabelOn = labelOn; // Ettiketten erzeugen ja/nein - Ausschalt-Möglichkeit


                Context.Settings.Update(settings);
            }
            catch
            {
                settings = new Settings() { Theme = "Wooja", CompanyName = companyName, DB = db };
                Context.Settings.Add(settings);
                Context.SaveChanges();
            }
               

              

            //} catch (Exception ex)
            //{
            //    settings = new Settings() { Theme = "Wooja", CompanyName = companyName, DB = db};
            //    sqliteContext.Settings.Add(settings);
            //}
            
            //   Settings settings = new Settings() { Theme = theme, CompanyName = companyName, Logo = logoPath, MwSt = tax, DB = db, Language = language, Server = server, Port = port, Version = version };

            Context.SaveChanges();


            return View(settings);
        }

        [HttpGet]
        public IActionResult Math(int x, int y)
        {
            // int result = x + y;
            MathService mathService = new MathService();
            
            return View(mathService.MathAddition(x, y));
        }
        public IActionResult Dashboard()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Editor(Category category, Brand brand, string name)
        { 
            Item item = new Item() { Name = name, Brand = brand };
         
            // tempContext.Tiere.Add(angelegtesTier);
            // tempContext.SaveChanges();
            return View();
        }

        [HttpGet]     // editor ohne parameter
        public IActionResult Editor()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
