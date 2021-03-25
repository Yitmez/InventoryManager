using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models
{
    public class Mandatory
    {
        [Key]
        public int Id { get; set; }
        public string MandatoryName { get; set; } // MO
        public string CompanyName { get; set; }  // M.O. Baumaschinen und Nutzfahrzeuge GmbH & Co. KG
        public string City { get; set; }
        public string Adres { get; set; }
        public string Phone { get; set; }
        public string ExtraField { get; set; }
    }
}
