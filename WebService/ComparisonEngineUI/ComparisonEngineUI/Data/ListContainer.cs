using System;
using System.Collections.Generic;
using ComparisonEngineUI.Models;
using System.Linq;

namespace ComparisonEngineUI.Data
{
    public class ListContainer
    {
        private static readonly Lazy<ListContainer> lazy = new Lazy<ListContainer>(() => new ListContainer());

        public static ListContainer Instance { get { return lazy.Value; } }

        private ListContainer()
        {

        }

        public List<Bar> barList = new List<Bar>();
        public List<Drink> drinkList = new List<Drink>();

        public Bar GetBarByID(Guid barID)
        {
            return barList.First(x => x.BarID == barID);
        }

    }
}
