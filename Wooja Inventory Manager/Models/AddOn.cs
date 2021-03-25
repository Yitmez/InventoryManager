using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models
{
    public class AddOn
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String License { get; set; }
        public DateTime ValidyTo { get; set; } // Gültig bis
        public bool IsAbo { get; set; }  // Abo-Form
        public string Interface { get; set; }
        public string AboPath { get; set; }  // evtl www.abo.wooja.de
        public string Port { get; set; }   // Port
        public string Key { get; set; }     // Prüf-Key oder Passwort???
        public string Info { get; set; }  // Infos

        public int Counter { get; set; }  // Counter - z.B. um zu zahlen wie viele noch kostenlos / oder zum Ablesen 
        public string Path { get; set; }  // Ordner wo Daten ausgetauscht werden können
        public string Str1 { get; set; }  // Extra String-Feld
        public int Int1 { get; set; }  // Extra Int Feld
        public DateTime DT1 { get; set; } // Extra DT Feld
        public bool Bool1 { get; set; }  // Extra Bool Feld




    }
}
