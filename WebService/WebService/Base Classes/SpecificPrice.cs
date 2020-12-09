using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Base_Classes
{
    public class SpecificPrice
    {
        public int SpecificPriceID { get; set; }
        public int BarID { get; set; }
        public Bar Bar { get; set; }
        public int DrinkID { get; set; }
        public Drink Drink { get; set; }
        public float DrinkPrice { get; set; }
    }
}
