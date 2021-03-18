using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models
{
    public class SubCategories
    {
        [Key]
        public int Id { get; set; }
        public string SubCategory { get; set; }
        public string Description { get; set; }
    }
}
