using System.Collections.Generic;
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
    }
}
