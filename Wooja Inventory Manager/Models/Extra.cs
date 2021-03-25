using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models
{
    public class Extra
    {
        [Key]
        public int Id { get; set; }
        public string ExtraName { get; set; }
        public string ExtraDesc { get; set; }
        public string ExtraField { get; set; }
       
    }
}
