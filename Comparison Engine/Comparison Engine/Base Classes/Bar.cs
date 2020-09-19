using System;
using System.Collections.Generic;
using System.Text;

namespace Comparison_Engine.Base_Classes
{
    class Bar
    {
        //ID of the bar
        public int barID { get; set; } 

        //Actual name of the bar
        public String barName { get; set; } 

        //Location of the bar
        public String location { get; set; } 

        public Bar(int barID, String barName, String location)
        {
            this.barID = barID;
            this.barName = barName;
            this.location = location;
        }

        //A dictionary of drinks available at this bar along with the prices, int for drink ID, float for price
        public Dictionary<int, float> availableDrinks = new Dictionary<int, float>();

        public void AddDrink(int drinkID, float price)
        {
            availableDrinks.Add(drinkID, price);
        }

        public float FindDrinkPrice(int drinkID)
        {
            //Return the price of specified drink at this bar
            return availableDrinks.ContainsKey(drinkID) ? availableDrinks[drinkID] : -1; //Should return something else besides -1 if drink not available here
        }
    }
}
