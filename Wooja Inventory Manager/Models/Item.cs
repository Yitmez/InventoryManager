using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Wooja_Inventory_Manager.Interfaces;

namespace Wooja_Inventory_Manager.Models
{
    public class Item : IItemGenerator
    {

        [Key]
        public int Id { get; set; }
        public string FolderNo { get; set; }
        public Category Category { get; set; }
        public Class Class { get; set; }
        public string Name { get; set; } // Unklar, evtl. für Eigennamen
        public Brand Brand { get; set; }
        public Type Type { get; set; }
        public string Description { get; set; }
        public string SN { get; set; }
        public Assets Assets { get; set; }
       
    public ContractData CInfo { get; set; } = new ContractData();
    public List<Tag> Tags { get; set; }
        public Color Color { get; set; }
        public SubCategory SubCategory { get; set; }
        public int ConstructionYear { get; set; }
        public Status Status { get; set; }
        public Condition Condition { get; set; }
        public int NetAmount { get; set; }
       
        public Localization Local { get; set; }
    public bool Sold { get; set; }
        public Customer SoldTo { get; set; }
        public User SoldBy { get; set; }
        public DateTime SoldDate { get; set; }
        public bool Reserved { get; set; }
        public int LendOutAmount { get; set; }
        public bool LendOut { get; set; }
        public DateTime LendOutDate { get; set; }
        public Customer LendOutTo { get; set; }
    public bool LocalSale { get; set; }
    public DateTime LastSeenOn { get; set; }
    public bool CurrentInv { get; set; }
    public List<Inventory> Inventory { get; set; }
        public Log LogInfos { get; set; } = new Log();
      
        public List<ExtFields> ExtFields { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }  // 47.60879681163666, -122.34064140082347

    }
}
