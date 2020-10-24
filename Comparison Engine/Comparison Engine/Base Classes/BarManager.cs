using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
        public Dictionary<int, Bar> barDictionary  { get; set; }

        //Adds a new bar
        public void AddBar(string barName, string location)
        {
            int barID = barDictionary.Count - 1;
            barDictionary.Add(barID, new Bar(barID, barName, location));
        }

        //Removes the bar from the list of all bars
        public void RemoveBar(Bar bar)
        {
            barDictionary.Remove(bar.barID);
        }

        //Finds the price of a specific drink at a specific bar
        public float FindDrinkPrice(int barID, int drinkID)
        {
            //Return the price of specified drink at this bar
            if (barDictionary[barID].availableDrinks.TryGetValue(drinkID, out float value))
            {
                return value;
            }
            else
            {
                return -1;
            }
        }

        //Returns a list of all drinks at a specified bar
        public Dictionary<int, float> FindAllDrinksAtBar(int barID)
        {
            return barDictionary[barID].availableDrinks;
        }

        //Returns specific Bar obejcts by some property
        public Bar GetBarByID(int barID)
        {
            return barDictionary[barID];
        }

        public Bar GetBarByName(string barName)
        {
            return barDictionary.Values.First(x => x.barName == barName);
        }

        public Bar GetBarByLocation(string barLocation)
        {
            return barDictionary.Values.First(x => x.barLocation == barLocation);
        }
    }
}
