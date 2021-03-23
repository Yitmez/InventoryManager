using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models
{
    public class Localization
    {
        [Key]
        public int Id { get; set; }
        public string Location { get; set; }
        public string Sector { get; set; }
        public string Shelf { get; set; }
        public string ANNumber { get; set; } // Alphanumeric number

        //public Localization ()
        //{
        //    new Localization(); 
        //}
    }
}
