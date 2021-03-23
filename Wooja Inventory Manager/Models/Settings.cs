using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }
       public string Theme { get; set; }
       public string CompanyName { get; set; }
        public string Logo { get; set; }   
       public  int MwSt { get; set; }
       public int DateYear { get; set; }
        public string Language { get; set; }
      
        public  int AmongLabels { get; set; }
       public bool LabelOn { get; set; }
        public string Server { get; set; }
        public string Port { get; set; }
        public string PW { get; set; }
        public string Server2 { get; set; }
        public string Port2 { get; set; }
        public string PW2 { get; set; }
        public string LicenceType { get; set; }
        public string ProductKey { get; set; }
        public string LicenceChecked { get; set; }
        public LogFile ProgramLog{ get; set; } = new LogFile();
        public List<ExtFields> ExtFields { get; set; } // Alle Felder die Hier angelegt
                                                       // werden fließen bei Neuanlegen von Items
                                                       // in den entsprechenden ExtFields Liste mit rein


    }
}
