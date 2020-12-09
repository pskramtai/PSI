using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComparisonEngineUI.Models
{
    public class SpecificPrice
    {
        public int BarID { get; set; }
        public Bar Bar { get; set; }
        public int DrinkID { get; set; }
        public Drink Drink { get; set; }
        public float DrinkPrice { get; set; }
    }
}
