using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Base_Classes
{
    public class SpecificPrice
    {
        public Guid BarID { get; set; }
        public Guid DrinkID { get; set; }
        public float DrinkPrice { get; set; }
    }
}
