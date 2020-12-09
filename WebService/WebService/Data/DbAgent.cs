using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebService.Base_Classes;

namespace WebService.Data
{
    public class DbAgent
    {
        public static List<Bar> GetBars(DbContextOptions<DBContext> options)
        {
            using (var dbContext = new DBContext(options))
            {
                return dbContext.Bars.ToList();
            }
        }

        public static List<Drink> GetDrinks(DbContextOptions<DBContext> options)
        {
            using (var dbContext = new DBContext(options))
            {
                return dbContext.Drinks.ToList();
            }
        }

        public static List<SpecificPrice> GetSpecificPrices(DbContextOptions<DBContext> options)
        {
            using (var dbContext = new DBContext(options))
            {
                return dbContext.SpecificPrices.ToList();
            }
        }

        public static void SaveBar(DbContextOptions<DBContext> options, Bar bar)
        {
            using (var dbContext = new DBContext(options))
            {
                dbContext.Bars.Add(bar);
                dbContext.SaveChanges();
            }
        }

        public static void SaveDrink(DbContextOptions<DBContext> options, Drink drink)
        {
            using (var dbContext = new DBContext(options))
            {
                dbContext.Drinks.Add(drink);
                dbContext.SaveChanges();
            }
        }

        public static void SaveSpecificPrice(DbContextOptions<DBContext> options, SpecificPrice specificPrice)
        {
            using (var dbContext = new DBContext(options))
            {
                dbContext.SpecificPrices.Add(specificPrice);
                dbContext.SaveChanges();
            }
        }
    }
}
