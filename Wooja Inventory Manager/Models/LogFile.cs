using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models
{
    public class LogFile
    {
        [Key]
        public int Id { get; set; }
        public User LastUser { get; set; }
        public DateTime LastChanges { get; set; }
        public string LastActivity { get; set; }
        public string Comment { get; set; }
}
}
