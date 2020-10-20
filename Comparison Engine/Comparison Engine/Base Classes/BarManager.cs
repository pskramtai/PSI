using System;
using System.Collections.Generic;

namespace Comparison_Engine.Base_Classes
{
    public sealed class BarManager
    {
        private static readonly Lazy<BarManager> lazy = new Lazy<BarManager>(() => new BarManager());

        public static BarManager Instance { get { return lazy.Value; } }

        private BarManager()
        {

        }

        //A list of bars
        public List<Bar> barList = new List<Bar>();

        //Adds a new bar
        public void AddBar(string barName, string location)
        {
            int barID = barList.Count - 1;
            barList.Add(new Bar(barID, barName, location));
        }

        //Removes the bar from the list of all bars
        public void RemoveBar(Bar bar)
        {
            barList.Remove(bar);
        }

        //Finds the price of a specific drink at a specific bar
        public float FindDrinkPrice(int barID, int drinkID)
        {
            //Return the price of specified drink at this bar
            if (barList[barID].availableDrinks.TryGetValue(drinkID, out float value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("FindDrinkPrice failed: bar does not have this drink");
                return -1;
            }
        }

        //Returns a list of all drinks at a specified bar
        public Dictionary<int, float> FindAllDrinksAtBar(int barID)
        {
            return barList[barID].availableDrinks;
        }
    }
}
