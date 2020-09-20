﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Comparison_Engine.Base_Classes
{
    class Drink
    {
        //ID of the drink
        public int drinkID { get; set; }

        //A dictionary of bars with this drink and the prices at those bars, int for bar ID, float for price
        public Dictionary<int, float> drinkLocations = new Dictionary<int, float>();

        public Drink(int drinkID)
        {
            this.drinkID = drinkID;
        }

        public void AddBar(int barID, float price)
        {
            drinkLocations.Add(barID, price);
        }

        //Returns a tuple of the lowest price and a list of ID's of bars with that price for the drink
        public Tuple<float, List<int>> FindLowestPrice()
        {
            float min = drinkLocations.Values.First();
            List<int> bars = new List<int>();
            bars.Add(drinkLocations.Keys.First());

            foreach (KeyValuePair<int, float> kvp in drinkLocations)
            {
                if(kvp.Value < min)
                {
                    bars.Clear();
                    min = kvp.Value;
                    bars.Add(kvp.Key);
                }
                else if(kvp.Value == min)
                {
                    bars.Add(kvp.Key);
                }
            }

            Tuple<float, List<int>> lowestPrice = new Tuple<float, List<int>>(min, bars);
            return lowestPrice;
        }

    }
}
