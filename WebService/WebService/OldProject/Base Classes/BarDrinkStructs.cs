using System.Collections.Generic;

namespace WebService.OldProject.Base_Classes
{
    //Structs for Bar and Drink Object properties
    public struct BarStruct
    {
        public string barName;

        public string barLocation;

        public BarStruct(string barName = null, string barLocation = null)
        {
            this.barName = barName;
            this.barLocation = barLocation;
        }
    }

    public struct DrinkStruct
    {
        public string drinkName;

        public List<string> ingredientList;

        public DrinkStruct(string drinkName = null, List<string> ingredientList = null)
        {
            this.drinkName = drinkName;
            this.ingredientList = ingredientList;
        }
    }
}
