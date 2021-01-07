using System;
using System.Collections.Generic;
using ComparisonEngineUI.Models;
using System.Linq;
using System.Threading.Tasks;
using ComparisonEngineUI.Views;

namespace ComparisonEngineUI.Data
{
    public class ListContainer
    {
        private static readonly Lazy<ListContainer> lazy = new Lazy<ListContainer>(() => new ListContainer());

        public static ListContainer Instance { get { return lazy.Value; } }

        public List<Bar> barList;
        public List<Drink> drinkList;
        public MapPage mapView;
        private ListContainer()
        {
            var restService = new RestService();
            barList = Task.Run(async () => await restService.GetData<List<Bar>>(Constants.BarsUrl)).Result;
            drinkList = Task.Run(async () => await restService.GetData<List<Drink>>(Constants.DrinksUrl)).Result;
        }

        public Bar GetBarByName(string barName)
        {
            return barList.First(x => x.BarName == barName);
        }

        public Drink GetDrinkByName(string drinkName)
        {
            return drinkList.First(x => x.DrinkName == drinkName);
        }

        public Bar GetBarByID(Guid id)
        {
            return barList.First(x => x.BarID == id);
        }

        public Drink GetDrinkByID(Guid id)
        {
            return drinkList.First(x => x.DrinkID == id);
        }
    }
}
