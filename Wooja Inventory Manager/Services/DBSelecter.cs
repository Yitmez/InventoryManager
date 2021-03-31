﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wooja_Inventory_Manager.Models.Context;

namespace Wooja_Inventory_Manager.Services
{

    public class DBSelecter : IDBSelecter
    {
        // ToDo:   Eingang/Ausgang -> SelectSQLite muss veränderbar sein

        public bool SelectSQLite => false;
        public string DefaultDBContext => "SqliteContext";
        public string SecondDBContext => "Sqlite2Context";

        string IDBSelecter.CurrentDBContext { get ; set ; }
        string IDBSelecter.selectedDBContext { get ; set; }

        //string IDBSelecter.CurrentDBContext { get; set; }
        public string CurrentDBContext;
        DbContext SelectedDB;
        //public string selectedDBContext;


        // DBSelecter dbSelector = new DBSelecter();
        public DBSelecter()
        {

            //CurrentDbContext = IDBSelecter.CurrentDbContext;

            if (SelectSQLite)
            {
             //  CurrentDBContext = DefaultDBContext;
                SelectedDB = new SqliteContext();

            } else
            {
                SelectedDB = new Sqlite2Context();
               // CurrentDBContext = SecondDBContext;
            }
            //if (SelectSQLite)
            //{
            //    SqliteContext CurrentDBContext = new SqliteContext();
            //    // CurrentDBContext = databaseContext;
            //    CurrentDBContext.Database.EnsureCreated();
            //    //return CurrentDBContext;
            //    selectedDBContext = CurrentDBContext;
            //}
            //else if (SelectSQLite == false)
            //{
            //    Sqlite2Context CurrentDBContext = new Sqlite2Context();
            //    CurrentDBContext.Database.EnsureCreated();
            //      selectedDBContext = CurrentDBContext;
                
            //}       
        }



        public DbContext GetCurrentDBContext()
        {
            return SelectedDB;
        }











        // DBSelecter()
        //{

        //    return SelectSQLite;
        //}

    }
}