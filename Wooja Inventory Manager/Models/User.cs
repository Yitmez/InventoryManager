using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name
        {
            get; set;
        }
        public Profile Profile
        {
            get; set;
        }
        public Rights Rights
        {
            get; set;
        }

        public bool GDPR
        {
            get; set;
        }
        public DateTime GDPRDate
        {
            get; set;
        }
        public bool TermsOfUse
        {
            get; set;
        }
        public DateTime TermsOfUseDate
        {
            get; set;
        }
        public string ExtraField
        {
            get; set;
        }
        public bool ExtraBoolField
        {
            get; set;
        }
        public Mandatory Mandatory
        {
            get; set;
        }

    }
}
