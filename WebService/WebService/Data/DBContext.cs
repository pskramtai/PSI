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

        public DbSet<Drink> Drink { get; set; }

        public DbSet<Bar> Bar { get; set; }
    }
}
