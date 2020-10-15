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

        //Finds the price of a specific drink at a specific bar
        public float FindDrinkPrice(int barID, int drink)
        {
            //Return the price of specified drink at this bar
            return barList[barID].availableDrinks.ContainsKey(drink) ? barList[barID].availableDrinks[drink] : -1; //Should return something else besides -1 if drink not available here
        }
    }
}
