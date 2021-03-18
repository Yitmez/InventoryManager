using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models
{
    public class Devices
    {
        [Key]
       public int  Id { get; set; }

  public  ContractData ContractId { get; set; } // verknüpft?
   public  Localization LocalId { get; set; }   // verknüpf?!!!
                                                // int LocalId { get; set; }

    public string FolderId { get; set; }
    public Classes Class { get; set; }
    public Categories Category { get; set; }

    public string Brand { get; set; }
    public string SN { get; set; }
    public string ConstructionYear { get; set; }
     public string Name { get; set; }
    public string Type { get; set; }
    public string Color { get; set; }
    public string RunningTime { get; set; } // hours or km
    public string Drive { get; set; } // Benzin, Diesel, Elektro
    public Tags[] Tags { get; set; }         // Tags z. B. Neuware, Magnetgreifer, Benziner
    public string Description { get; set; }
    public int Price { get; set; }
     public int NewPrice { get; set; }
    public Stati StatusId { get; set; }
    public bool OnStock { get; set; }
    public bool Reserved { get; set; }
    public bool LendOut { get; set; }
    public bool LocalSale { get; set; }
    private int PlaceId { get; set; }
    public bool CE { get; set; }




    }
}
