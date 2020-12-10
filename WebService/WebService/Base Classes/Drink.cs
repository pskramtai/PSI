﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebService.Base_Classes
{
    public class Drink
    {
        //ID of the drink
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid DrinkID { get; set; }

        //Name of the drink
        [MaxLength(50)]
        public string DrinkName { get; set; }

        //List of ingredients in this drink, mainly used by cocktails
        //public List<string> IngredientList { get; set; }

        //A list of bars with this drink and the prices at those bars, int for bar ID, float for price
        public List<SpecificPrice> DrinkLocations { get; set; }

        public Drink(string drinkName/*, List<string> ingredientList = null*/)
        {
            this.DrinkName = drinkName;
            this.DrinkID = new Guid();
            //this.IngredientList = ingredientList;
        }
    }
}
