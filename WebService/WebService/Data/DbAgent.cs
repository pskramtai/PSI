using Comparison_Engine.Base_Classes;
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
        //private string connectionString = "Server=tcp:comparison-engine.database.windows.net,1433;Initial Catalog=Comparison Engine;Persist Security Info=False;User ID=PSIadmin;Password=CompEngine123Ė;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public static List<Bar> GetBars(DbContextOptions<DBContext> options)
        {
            try
            {
                using (var dbContext = new DBContext(options))
                {
                    return dbContext.Bars.ToList();
                }
            }
            catch (Exception e)
            {
                
                throw;
            }
        }

        public static List<Drink> GetDrinks(DbContextOptions<DBContext> options)
        {
            try
            {
                using (var dbContext = new DBContext(options))
                {
                    return dbContext.Drinks.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<SpecificPrice> GetSpecificPrices(DbContextOptions<DBContext> options)
        {
            try
            {
                using (var dbContext = new DBContext(options))
                {
                    return dbContext.SpecificPrices.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void SaveBar(DbContextOptions<DBContext> options, Bar bar)
        {
            try
            {
                using (var dbContext = new DBContext(options))
                {
                    dbContext.Bars.Add(bar);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void SaveDrink(DbContextOptions<DBContext> options, Drink drink)
        {
            try
            {
                using (var dbContext = new DBContext(options))
                {
                    dbContext.Drinks.Add(drink);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void SaveSpecificPrice(DbContextOptions<DBContext> options, SpecificPrice specificPrice)
        {
            try
            {
                using (var dbContext = new DBContext(options))
                {
                    dbContext.SpecificPrices.Add(specificPrice);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
