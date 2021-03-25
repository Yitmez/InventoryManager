using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models
{
    public class Color
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String HexCode { get; set; }

    }
}
