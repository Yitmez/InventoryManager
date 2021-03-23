using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models.Context
{
    public class SqliteContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=InventorySqlite.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Settings> Settings { get; set; }
        public DbSet<Assets> Assets { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ContractData> ContractData { get; set; }
        public DbSet<ExtFields> ExtFields { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<Category> Categories { get; set; }
       public DbSet<SubCategory> SubCategories { get; set; }
       public DbSet<Status> Stati { get; set; }
       public DbSet<User> Users { get; set; }
       public DbSet<Localization> Location { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<LogFile> LogFile { get; set; }
        public DbSet<Mandatory> Mandatories { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Rights> Rights { get; set; }


     
    }
    
}
