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

        //Adds a location where a drink can be found
        public void AddBar(int drinkID, int barID, float price)
        {
            drinkList[drinkID].drinkLocations.Add(barID, price);
        }

        //Returns a tuple of the lowest price and a list of ID's of bars with that price for the drink
        public Tuple<float, List<int>> FindLowestPrice(int drinkID)
        {
            Dictionary<int, float> drinkLocations = drinkList[drinkID].drinkLocations;
            float min = drinkLocations.Values.First();
            List<int> bars = new List<int>();
            bars.Add(drinkLocations.Keys.First());

            foreach (KeyValuePair<int, float> kvp in drinkLocations)
            {
                if (kvp.Value < min)
                {
                    bars.Clear();
                    min = kvp.Value;
                    bars.Add(kvp.Key);
                }
                else if (kvp.Value == min)
                {
                    bars.Add(kvp.Key);
                }
            }

            Tuple<float, List<int>> lowestPrice = new Tuple<float, List<int>>(min, bars);
            return lowestPrice;
        }
    }
}
