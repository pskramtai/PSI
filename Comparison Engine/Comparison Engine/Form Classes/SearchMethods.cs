using Comparison_Engine.Base_Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comparison_Engine.Form_Classes
{
    class SearchMethods
    {

        public static Dictionary<int, Bar> SearchForBars(Dictionary<int, Bar> currentBarList, String keyword)
        {
            Dictionary<int, Bar> bars = new Dictionary<int, Bar>();
            foreach (Bar bar in currentBarList.Values)
            {
                if (bar.barName.ToLower().Contains(keyword.ToLower()))
                {
                    bars.Add(bar.barID, bar);
                }
            }
            return bars;
        }


        public static Dictionary<int, Drink> SearchForDrinks(Dictionary<int, Drink> currentDrinkList, String keyword)
        {
            Dictionary<int, Drink> drinks = new Dictionary<int, Drink>();
            foreach (Drink drink in currentDrinkList.Values)
            {
                if (drink.drinkName.ToLower().Contains(keyword.ToLower()))
                {
                    drinks.Add(drink.drinkID, drink);
                }
            }
            return drinks;
        }
    }
}
