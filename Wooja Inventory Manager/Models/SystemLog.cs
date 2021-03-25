using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models
{
    public class SystemLog
    {
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime DateTime { get; set; }
        public string Type { get; set; } // Warning / Critical / Information
        public string Info { get; set; }
    }
}
