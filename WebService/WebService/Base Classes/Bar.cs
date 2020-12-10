using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebService.Base_Classes
{
    public partial class Bar
    {
        //ID of the bar
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid BarID { get; set; }

        //Actual name of the bar
        [MaxLength(50)]
        public string BarName { get; set; }

        //Location of the bar
        [MaxLength(50)]
        public string BarLocation { get; set; }

        //A list of drinks available at this bar along with the prices
        public virtual ICollection<SpecificPrice> AvailableDrinks { get; set; }

        public Bar(string barName, string barLocation, Guid barID)
        {
            this.BarName = barName;
            this.BarLocation = barLocation;
            // this.BarID = (Guid)barID;
            this.BarID = barID;
            AvailableDrinks = new HashSet<SpecificPrice>();
        }
    } 
}
