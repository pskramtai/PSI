﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebService.Base_Classes;

namespace Comparison_Engine.Base_Classes
{
    public class Drink
    {
        //ID of the drink
        public int drinkID { get; set; }

        //Name of the drink
        [MaxLength(50)]
        public string drinkName { get; set; }

        //List of ingredients in this drink, mainly used by cocktails
        public List<string> ingredientList = new List<string>(); // actually surprised I'm adding this only now

        //A list of bars with this drink and the prices at those bars, int for bar ID, float for price
        [NotMapped]
        public List<SpecificPrice> drinkLocations { get; set; }
        public Drink(int drinkID, string drinkName)
        {
            this.drinkID = drinkID;
            this.drinkName = drinkName;
        }

        //Changes properties of this Drink Object
        public void EditDrink(DrinkStruct drinkStruct)
        {
            if (drinkStruct.drinkName != null) 
            { 
                this.drinkName = drinkStruct.drinkName; 
            }

            if (drinkStruct.ingredientList != null)
            {
                this.ingredientList = drinkStruct.ingredientList;
            }
        }

        //Adds a location where a drink can be found
        /*public void AddBar(int barID, float price)
        {
            drinkLocations.Add(barID, price);
        }

        //edits the price of the drink at the specified bar
        public void EditPrice(int barID, float newPrice)
        {
            drinkLocations[barID] = newPrice;
        }

        //Removes the bar from the dictionary of available bars
        public void RemoveAvailableBar(int barID)
        {
            drinkLocations.Remove(barID);
        }*/
    }
}
