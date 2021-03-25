using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models
{
    public class Rights
    {
        [Key]
        public int Id { get; set; }
        public string RightsName { get; set; }
    }
}
