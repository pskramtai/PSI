using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComparisonEngineUI.Models
{
    public class SpecificPrice
    {
        public int SpecificPriceID { get; set; }
        public Guid BarID { get; set; }
        public Bar Bar { get; set; }
        public Guid DrinkID { get; set; }
        public Drink Drink { get; set; }
        public float DrinkPrice { get; set; }
    }
}
