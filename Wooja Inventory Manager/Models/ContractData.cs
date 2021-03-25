using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models
{
    public class ContractData
    {
        [Key]
        public int CDId { get; set; }
        public string Seller { get; set; }
        public DateTime PurchasingDate { get; set; }
        public int PurchasingValue { get; set; }
        public string PInvoiceNo { get; set; }
        public int ValueOfGood { get; set; }

        public DateTime PayDate { get; set; }
        public int SellingPrice { get; set; }
        public string InvoiceNo { get; set; }
        public string Customer { get; set; }
        public string CustomerLand { get; set; }
        public string CustomerAdres { get; set; }
        public string Info { get; set; }
        public bool Payed { get; set; }
        
        public ContractData ()
        {
           // new ContractData();
        }
    }
}
