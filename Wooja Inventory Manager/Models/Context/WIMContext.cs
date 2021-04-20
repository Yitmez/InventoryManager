using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Models.Context
{
    public class WIMContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = WIMDb");
            //optionsBuilder.UseSqlite("Data Source=InventorySqlite.db");
            base.OnConfiguring(optionsBuilder);
        }
        public WIMContext()
        {

        }
        public WIMContext(DbContextOptions<WIMContext> opts)  // Parameterweitergabe - über DI die "Server = (localdb)\\MSSQLLocalDB; Database = WIMDb" 
           : base(opts) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Settings>().HasData(
                new Settings
                {
                    Id = 1,
                    Theme = "Standard",
                    DB = "Sqlite",
                    CompanyName = "",
                  

        }) ;

            modelBuilder.Entity<User>().HasData(
              new User
              {
                  Id = 1,
                  Name = "Admin",
                  TermsOfUse = true
                  // Rights => Id = 1 (Administrator)
              },
              
  new User { Id = 2, Name = "Yitmez", TermsOfUse = true },
   new User { Id = 3, Name = "Gast", TermsOfUse = true}) ;

            modelBuilder.Entity<Rights>().HasData(
             new Rights
             {  Id = 1, RightsName = "Administrator" },
             new Rights { Id = 2, RightsName = "User" });

            modelBuilder.Entity<Brand>().HasData(
             new Brand
             {
                 Id = 1,
                 Name = "Mercedes-Benz",
              },
             new Brand { Id = 2, Name = "MAN"  },
              new Brand { Id = 3, Name = "Caterpillar" });

          



            modelBuilder.Entity<Color>().HasData(
 new Color { Id = 1, Name = "Schwarz", HexCode = "00000"},
  new Color { Id = 2, Name = "Weiss", HexCode = "00000" },
    new Color { Id = 3, Name = "Blau", HexCode = "00000" },
    new Color { Id = 4, Name = "Gelb", HexCode = "00000" },
      new Color { Id = 5, Name = "Rot", HexCode = "00000" },
   new Color { Id = 6, Name = "Grün", HexCode = "00000" });

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
