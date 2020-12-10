using System;
using System.Collections.Generic;
using System.Text;
using ComparisonEngineUI.Views;
using Xamarin.Forms;
using ComparisonEngineUI.Models;
using ComparisonEngineUI.Data;

namespace ComparisonEngineUI.ViewModels
{

    public class DrinkViewModel : BaseViewModel
    {
        private ListContainer listContainer = ListContainer.Instance;

        public Drink drink;
        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnPropertyChanged();
            }
        }
 
        private List<SpecificPrice> _SpecificPriceList { get; set; }
        public List<SpecificPrice> SpecificPriceList
        {
            get
            {
                return _SpecificPriceList;
            }
            set
            {
                if (value != _SpecificPriceList)
                {
                    _SpecificPriceList = value;
                    OnPropertyChanged();
                }
            }
        }
        public DrinkViewModel(string DrinkName)
        {
            drink = listContainer.GetDrinkByName(DrinkName);
            Name = drink.DrinkName;
            SpecificPriceList = drink.DrinkLocations;
        }
    }
}
