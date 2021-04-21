using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wooja_Inventory_Manager.Models;
using Wooja_Inventory_Manager.Models.Context;
using Wooja_Inventory_Manager.Services;

namespace Wooja_Inventory_Manager.Controllers
{
    public class ItemsController : Controller
            {

        WIMContext context;
        public ItemsController( WIMContext context) // IDBSelecter selecter später differenzieren
        {
            this.context = context;
      //      context = selecter.GetCurrentDBContext();
        }
        
        // WIMContext context = new WIMContext();
        // GET: ItemsController
        public ActionResult ItemsView()
        {
           
            return View(context.Items);
        }

        // GET: ItemsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ItemsController/Create
        public ActionResult Create()
        {
            //IList<Brand> brandList = new List<Brand>() {
            //        new Brand(){ Id=1, Name="Mercedes-Benz" },
            //         new Brand(){ Id=2, Name="MAN" },
            //         new Brand(){ Id=3, Name="Liebherr" }

            //    };
            ViewBag.BrandList = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> {
             new SelectListItem(){ Value="1", Text="Mercedes-Benz" },
                     new SelectListItem(){ Value="2", Text="MAN" },
                     new SelectListItem(){ Value="3", Text="Liebherr", Selected = true }
            };
            try
            {
               
                return View();

            }
            catch
            {
                return View();
            }
           
        }

        // POST: ItemsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, string internNo, string name, string description,
            string sn, int constructionYear, int netAmount, bool sold, int brandId, // Status status,  Color color,  Models.Type type
            DateTime soldDate,
             bool reserved, int lendOutAmount, bool lendOut, DateTime lendOutDate,  Customer soldTo // User soldBy, 
          , Customer lendOutTo, bool localSale, DateTime lastSeenOn, bool currentInv) // Condition condition, Localization local, 
        {
            try
            {
                Item item = new Item()
                {
                    InternNo = internNo,
                    Name = name,
                    Description = description,
                    SN = sn,
                    ConstructionYear = constructionYear,
                    NetAmount = netAmount,
                    Sold = sold,
                    // Color = color,
                    //Status = status,
                    // Type = type,
                    Brand = context.Brands.Find(brandId),
                   SoldDate = soldDate,
                    Reserved = reserved,
                    LendOutAmount=lendOutAmount,
                    LendOut = lendOut,
                    LendOutDate = lendOutDate,
                    LendOutTo = lendOutTo,
                    LocalSale = localSale,
                    //Condition = condition,
                    CurrentInv = currentInv,

                };
                context.Items.Add(item);

                context.SaveChanges();
               return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return View();
            }
        }

        // GET: ItemsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ItemsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemsController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {

            var item = await context.Items
      .AsNoTracking()
      .FirstOrDefaultAsync(i => i.Id == id);

            if (item == null)
            {
                return NotFound();
            }
            
            else
            {

                // context.Items.Remove(item);
                // context.SaveChanges();
                // Lieber erst nach bestätigung löschen
            }


            return View(item);
        }

        // POST: ItemsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            var item = await context.Items
     .AsNoTracking()
     .FirstOrDefaultAsync(i => i.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            else
            {
                context.Items.Remove(item);
                context.SaveChanges();
            }
            return View();
            
        }
    }
}
