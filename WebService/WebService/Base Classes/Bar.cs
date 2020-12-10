﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebService.Base_Classes
{
    public partial class Bar
    {
        //ID of the bar
        public Guid BarID { get; set; } 

        //Actual name of the bar
        [MaxLength(50)]
        public string BarName { get; set; } 

        //Location of the bar
        [MaxLength(50)]
        public string BarLocation { get; set; }

        //A list of drinks available at this bar along with the prices
        public virtual ICollection<SpecificPrice> AvailableDrinks { get; set; }

        public Bar()
        {
            AvailableDrinks = new HashSet<SpecificPrice>();
        }
    }
}
