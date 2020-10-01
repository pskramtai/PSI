using System.Collections.Generic;

namespace Comparison_Engine.Base_Classes
{
    public class Drink
    {
        //ID of the drink
        public int drinkID { get; set; }

        //Name of the drink
        public string drinkName { get; set; }

        public Drink(int drinkID, string drinkName)
        {
            this.drinkID = drinkID;
            this.drinkName = drinkName;
        }

        //A dictionary of bars with this drink and the prices at those bars, int for bar ID, float for price
        public Dictionary<int, float> drinkLocations = new Dictionary<int, float>();
    }
}
