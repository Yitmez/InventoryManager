using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models
{
    public class Tags
    {
        [Key]
        public int Id { get; set; }
        public string Tag { get; set; }
        public string TagDescription { get; set; }
    }
}
