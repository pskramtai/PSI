using System;
using System.Collections.Generic;
using System.Linq;

namespace Comparison_Engine.Base_Classes
{
     public sealed class DrinkManager
    {
        private static readonly Lazy<DrinkManager> lazy = new Lazy<DrinkManager>(() => new DrinkManager());

        public static DrinkManager Instance { get { return lazy.Value; } }

        private DrinkManager()
        {

        }

        //A list of drinks
        public List<Drink> drinkList = new List<Drink>();

        //Adds a new drink to the list
        public void AddDrink(string drinkName)
        {
            int drinkID = drinkList.Count - 1;
            drinkList.Add(new Drink(drinkID, drinkName));
        }

        //Removes a drink from the drink list
        public void RemoveDrink(Drink drink)
        {
            drinkList.Remove(drink);
        }

        //Returns a tuple of the lowest price and a list of ID's of bars with that price for the drink
        public Tuple<float, List<int>> FindLowestPrice(int drinkID)
        {
            //Dictionary<int, float> drinkLocations = drinkList[drinkID].drinkLocations;
            //float min = drinkLocations.Values.First();
            //List<int> bars = new List<int>();
            //bars.Add(drinkLocations.Keys.First());

            //foreach (KeyValuePair<int, float> kvp in drinkLocations)
            //{
            //    if (kvp.Value < min)
            //    {
            //        bars.Clear();
            //        min = kvp.Value;
            //        bars.Add(kvp.Key);
            //    }
            //    else if (kvp.Value == min)
            //    {
            //        bars.Add(kvp.Key);
            //    }
            //}

            //Updated to look through using LINQ, leaving old logic behind for now in case it is needed
            var lowestPrice = drinkList[drinkID].drinkLocations
                                                .Min(x => x.Value);

            var lowestPriceLocations = drinkList[drinkID].drinkLocations
                                                         .Where(x => x.Value == lowestPrice)
                                                         .Select(x => x.Key)
                                                         .ToList();

            

            //Tuple<float, List<int>> lowestPrice = new Tuple<float, List<int>>(min, bars);
            return new Tuple<float, List<int>>(lowestPrice, lowestPriceLocations);
        }

        //Returns a Disctionary of Bars with specified drink
        public Dictionary<int, float> FindAllBarsWithDrink(int drinkID)
        {
            return drinkList[drinkID].drinkLocations;
        }
    }
}
