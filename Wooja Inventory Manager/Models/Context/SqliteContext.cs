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
        public DbSet<Devices> Devices { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<ContractData> ContractData { get; set; }

        public DbSet<Classes> Classes { get; set; }
 
         public DbSet<Categories> Categories { get; set; }
       public DbSet<SubCategories> SubCategories { get; set; }
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
