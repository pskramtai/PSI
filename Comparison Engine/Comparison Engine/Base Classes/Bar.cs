using System.Collections.Generic;

namespace Comparison_Engine.Base_Classes
{
    public class Bar
    {
        //ID of the bar
        public int barID { get; set; } 

        //Actual name of the bar
        public string barName { get; set; } 

        //Location of the bar
        public string barLocation { get; set; } 

        public Bar(int barID, string barName, string barLocation)
        {
            this.barID = barID;
            this.barName = barName;
            this.barLocation = barLocation;
        }

        //Changes properties of this Bar Object
        public void EditBar(BarStruct barStruct)
        {
            if (barStruct.barName != null) this.barName = barStruct.barName;
            if (barStruct.barLocation != null) this.barLocation = barStruct.barLocation;
        }

        //A dictionary of drinks available at this bar along with the prices
        public Dictionary<int, float> availableDrinks = new Dictionary<int, float>();

        //Adds a drink to the bar's menu
        public void AddDrink(int drinkID, float price)
        {
            availableDrinks.Add(drinkID, price);
        }

        //Removes a drink from this bar's menu
        public void RemoveDrink(int drinkID)
        {
            availableDrinks.Remove(drinkID);
        }

        //Changes the price of a drink at this bar
        public void EditDrinkPrice(int drinkID, float newPrice)
        {
            availableDrinks[drinkID] = newPrice;
        }
    }
}
