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
        public DbSet<Item> Items { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ContractData> ContractData { get; set; }

        public DbSet<Class> Classes { get; set; }
 
         public DbSet<Category> Categories { get; set; }
       public DbSet<SubCategory> SubCategories { get; set; }
       public DbSet<Stati> Stati { get; set; }
       public DbSet<User> Users { get; set; }
       public DbSet<Localization> Locals { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Devices>()
        //        .HasOne(p => p.Status)
        //        .WithMany(b => b.Tags);
       }
    
}
