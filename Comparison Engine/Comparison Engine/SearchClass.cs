using Comparison_Engine.Base_Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comparison_Engine
{
    class SearchClass
    {
        public static List<Bar> SearchForBars(List<Bar> currentBarList, String keyword)
        {
            List<Bar> bars = new List<Bar>();
            foreach(Bar bar in currentBarList)
            {
                if(bar.barName.ToLower().Contains(keyword.ToLower()))
                {
                    bars.Add(bar);
                }
            }
            return bars;
        }


        public static List<Drink> SearchForDrinks(List<Drink> currentDrinkList, String keyword)
        {
            List<Drink> drinks = new List<Drink>();
            foreach (Drink drink in currentDrinkList)
            {
                if(drink.drinkName.ToLower().Contains(keyword.ToLower()))
                {
                    drinks.Add(drink);
                }
            }
            return drinks;
        }
    }
}
