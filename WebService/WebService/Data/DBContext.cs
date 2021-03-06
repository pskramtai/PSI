﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
            /*modelBuilder.Entity<Bar>()
                .HasMany<SpecificPrice>(b => b.AvailableDrinks)
                .WithOne(s => s.Bar)
                .HasForeignKey(s => s.BarID);

            modelBuilder.Entity<Drink>()
                .HasMany<SpecificPrice>(d => d.DrinkLocations)
                .WithOne(s => s.Drink)
                .HasForeignKey(s => s.DrinkID);*/
        }

        public DbSet<Drink> Drink { get; set; }

        public DbSet<Bar> Bar { get; set; }

        public DbSet<SpecificPrice> SpecificPrice { get; set; }
    }
}
