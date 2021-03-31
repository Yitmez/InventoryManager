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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Settings>().HasData(
                new Settings
                {
                    Id = 1,
                    Theme = "Wooja",
                    DB = "Sqlite",
                    CompanyName = "",
                  

        }) ;
        }

        public DbSet<Settings> Settings { get; set; } 
        public DbSet<SystemLog> SystemLog { get; set; }
        public DbSet<Assets> Assets { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ContractData> ContractDatas { get; set; }
        public DbSet<ExtFields> ExtFields { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Extra> Extras{ get; set; }
        public DbSet<Category> Categories { get; set; }
       public DbSet<SubCategory> SubCategories { get; set; }
       public DbSet<Status> Stati { get; set; }
       public DbSet<User> Users { get; set; }
       public DbSet<Localization> Location { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
      public DbSet<Log> Log { get; set; }
        public DbSet<Mandatory> Mandatories { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Rights> Rights { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<AddOn> AddOns { get; set; }
        



    }
    
}
