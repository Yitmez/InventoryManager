using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models
{
    public class Category // : ViewComponent   // ViewComponent evtl entfernen... sollte als View Component in Settings einfließen
    {                                          // laut s. 589
        [Key]
        public int Id{ get; set; }
        public string Name { get; set; }
    }


}
