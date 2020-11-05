using System.Collections.Generic;

namespace Comparison_Engine.Base_Classes
{
    public class Drink
    {
        //ID of the drink
        public int drinkID { get; set; }

        //Name of the drink
        public string drinkName { get; set; }

        //List of ingredients in this drink, mainly used by cocktails
        public List<string> ingredientList = new List<string>(); // actually surprised I'm adding this only now

        //A dictionary of bars with this drink and the prices at those bars, int for bar ID, float for price
        public Dictionary<int, float> drinkLocations = new Dictionary<int, float>();

        public Drink(int drinkID, string drinkName)
        {
            this.drinkID = drinkID;
            this.drinkName = drinkName;
        }

        //Changes the name of this drink object
        public void EditDrinkName(string newName)
        {
            drinkName = newName;
        }

        //Adds a location where a drink can be found
        public void AddBar(int barID, float price)
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
        }
    }
}
