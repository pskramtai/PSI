﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace WebService.OldProject.Base_Classes
{
     public sealed class DrinkManager
    {
        private static readonly Lazy<DrinkManager> lazy = new Lazy<DrinkManager>(() => new DrinkManager());

        public static DrinkManager Instance { get { return lazy.Value; } }

        private DrinkManager()
        {

        }

        //A list of drinks
        public Dictionary<int, DrinkOld> drinkDictionary; //= Data.GetDrinks();

        //Adds a new drink to the list
        public void AddDrink(string drinkName)
        {
            int drinkID = drinkDictionary.Keys.Max() + 1; //changed up the way we assign ID's as using Count() would still cause trouble when removing elements
            drinkDictionary.Add(drinkID, new DrinkOld(drinkID, drinkName));
        }

        //Removes a drink from the drink list
        public void RemoveDrink(DrinkOld drink)
        {
            drinkDictionary.Remove(drink.drinkID);
        }

        //Returns a tuple of the lowest price and a list of ID's of bars with that price for the drink
        public Tuple<float, List<int>> FindLowestPrice(int drinkID)
        {
            try
            {
                var lowestPrice = FindAllBarsWithDrink(drinkID)
                                  .Min(x => x.Value);

                var lowestPriceLocations = FindAllBarsWithDrink(drinkID)
                                       .Where(x => x.Value == lowestPrice)
                                       .Select(x => x.Key)
                                       .ToList();

                return new Tuple<float, List<int>>(lowestPrice, lowestPriceLocations);
            }
            catch(ArgumentNullException e)
            {
                return null;
            }
        }

        //Returns a Disctionary of Bars with specified drink
        public Dictionary<int, float> FindAllBarsWithDrink(int drinkID)
        {
            if (drinkDictionary.TryGetValue(drinkID, out DrinkOld value))
            {
                return value.drinkLocations;
            }
            else
            {
                return null;
            }
        }

        //Returns specific Drink objects by some property
        public DrinkOld GetDrinkByID(int drinkID)
        {
            if (drinkDictionary.TryGetValue(drinkID, out DrinkOld value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        public DrinkOld GetDrinkByName(string drinkName)
        {
            try
            {
                return drinkDictionary.Values.First(x => x.drinkName == drinkName);
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
    }
}
