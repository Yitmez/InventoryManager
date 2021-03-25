using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string CName { get; set; }
        public string Adres { get; set; }
        public string City { get; set; }
        public string Land { get; set; }
        public string PersonFN1 { get; set; }
        public string PersonSN1 { get; set; }
        public string PhoneNo1 { get; set; }
        public string Email1 { get; set; }
        public string PersonFN2 { get; set; }
        public string PersonSN2 { get; set; }
        public string PhoneNo2 { get; set; }
        public string Email2 { get; set; }
        public bool GDPR
        {
            get; set;
        }
        public DateTime GDPRDate
        {
            get; set;
        }
        public string Asset
        {
            get; set;
        }
        public string CType  // private / Compandy  
        {
            get; set;
        }
        public string CLocation   // Inland / EU / Drittland 
        {
            get; set;
        }
      
        public string Info   
        {
            get; set;
        }
        public ExtFields ExtFields
        {
            get; set;
        }
   

    }
}
