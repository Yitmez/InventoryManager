﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string InvSession { get; set; }    // string JSON =  Item, SN, Info, WarenWert, EK?
        public Mandatory Mandatory { get; set; }
        public DateTime InvDate { get; set; }
        public User Responsive { get; set; }
        public Log Changes { get; set; } = new Log();
        public string Info { get; set; }
        public string ExtraField { get; set; }

    }
}