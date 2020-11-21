using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebService.Base_Classes
{
    public class Bar
    {
        //ID of the bar
        public int barID { get; set; } 

        //Actual name of the bar
        [MaxLength(50)]
        public string barName { get; set; } 

        //Location of the bar
        [MaxLength(50)]
        public string barLocation { get; set; }

        //A list of drinks available at this bar along with the prices
        [NotMapped]
        public List<SpecificPrice> availableDrinks { get; set; }

        public Bar(int barID, string barName, string barLocation)
        {
            this.barID = barID;
            this.barName = barName;
            this.barLocation = barLocation;
        }
    }
}
