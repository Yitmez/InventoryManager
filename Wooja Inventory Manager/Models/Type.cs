using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models
{


    public class Type
    {
        private string _defaultVal = "Unknown";

        [Key]
        public int Id { get; set; }
        public string Name
        {
            get { return _defaultVal; }
            set { _defaultVal = value; }

        }
    }
}

