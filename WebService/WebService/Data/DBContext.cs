using Comparison_Engine.Base_Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebService.Base_Classes;

namespace WebService.Data
{
    public class DBContext : DbContext
    {
        public DbSet<Bar> Bars;
        public DbSet<Drink> Drinks;
        public DbSet<SpecificPrice> SpecificPrices;
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bar>().ToTable("Bars");
            modelBuilder.Entity<Drink>().ToTable("Drinks");
            modelBuilder.Entity<SpecificPrice>().HasNoKey().ToTable("SpecificPrices");
        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:comparison-engine.database.windows.net,1433;Initial Catalog=Comparison Engine;Persist Security Info=False;User ID=PSIadmin;Password=CompEngine123Ė;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            base.OnConfiguring(optionsBuilder);
        }*/
    }
}
