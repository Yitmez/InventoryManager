﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wooja_Inventory_Manager.Models;
using Wooja_Inventory_Manager.Models.Context;

namespace Wooja_Inventory_Manager.Controllers
{
    public class ItemsController : Controller
            {

        SqliteContext context = new SqliteContext();
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
        public ActionResult Create(IFormCollection collection, string folderNo, string name, Brand brand, 
            Models.Type type, Color color, int constructionYear, string description, string sn, Status status, 
            int netAmount,
            Localization local, bool sold, Customer soldTo, User soldBy, DateTime soldDate, bool reserved, 
           int lendOutAmount, bool lendOut, DateTime lendOutDate, Customer lendOutTo, bool localSale,
           DateTime lastSeenOn, bool currentInv, Condition condition)

        {

            try
            {

                Item item = new Item()
                {
                    FolderNo = folderNo,
                    Name = name,
                    Brand = brand,
                    Type = type,
                    Description = description,
                    SN = sn,
                    Color = color,
                    Status = status,
                    Sold = sold,
                    ConstructionYear = constructionYear,
                    Reserved = reserved,
                    LocalSale = localSale,
                    Condition = condition,
                    CurrentInv = currentInv,

                };
                context.Items.Add(item);

                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
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
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ItemsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
