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
        public string location { get; set; } 

        public Bar(int barID, string barName, string location)
        {
            this.barID = barID;
            this.barName = barName;
            this.location = location;
        }

        //A dictionary of drinks available at this bar along with the prices
        public Dictionary<Drink, float> availableDrinks = new Dictionary<Drink, float>();

        //Adds a drink to the bar's menu
        public void AddDrink(Drink drink, float price)
        {
            availableDrinks.Add(drink, price);
        }
    }
}
