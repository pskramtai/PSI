using System;
using System.Collections.Generic;
using System.Linq;

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
        public Dictionary<int, BarOld> barDictionary; //= Data.GetBars();

        //Adds a new bar
        public void AddBar(string barName, string location)
        {
            int barID = barDictionary.Keys.Max() + 1; //changed up the way we assign ID's as using Count() would still cause trouble when removing elements

            barDictionary.Add(barID, new BarOld(barID, barName, location));
        }

        //Removes the bar from the list of all bars
        public void RemoveBar(BarOld bar)
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
            if (barDictionary.TryGetValue(barID, out BarOld value))
            {
                return value.availableDrinks;
            }
            else
            {
                return null;
            }
        }

        //Returns specific Bar obejcts by some property
        public BarOld GetBarByID(int barID)
        {
            if (barDictionary.TryGetValue(barID, out BarOld value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        public BarOld GetBarByName(string barName)
        {
            try
            {
                return barDictionary.Values.First(x => x.barName == barName);
            }
            catch (ArgumentNullException e)
            {
                return null;
            }
            catch (InvalidOperationException e)
            {
                return null;
            }
        }

        public BarOld GetBarByLocation(string barLocation)
        {
            try
            {
                return barDictionary.Values.First(x => x.barLocation == barLocation);
            }
            catch(ArgumentNullException e)
            {
                return null;
            }
            catch(InvalidOperationException e)
            {
                return null;
            }
        }
    }
}
