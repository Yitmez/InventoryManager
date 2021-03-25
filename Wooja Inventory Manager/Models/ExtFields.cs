using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models
{
    public class ExtFields
    {
        [Key]
        public int Id { get; set; }  // Unklar ob Id nötig ?????

        public string XStringField { get; set; }
        public bool XBoolField { get; set; }
        public int XIntField { get; set; }
        public DateTime XDateTimeField { get; set; }
        

    }
}
