using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wooja_Inventory_Manager.Models.Context;

namespace Wooja_Inventory_Manager.Services
{
    public interface IDBSelecter
    {

        public bool SelectSQLite => true;
        public string CurrentDBContext { get; set; }
        public string selectedDBContext { get; set; }
        public WIMContext GetCurrentDBContext();
}
}
