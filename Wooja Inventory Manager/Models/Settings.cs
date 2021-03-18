using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }
       public string Theme { get; set; }
       public string CompanyName { get; set; }
        public string Logo { get; set; }   ////
       public  int MwSt { get; set; }
       public int DateYear { get; set; }
       public  int AmongLabels { get; set; }
       public bool LabelOn { get; set; }

    }
}
