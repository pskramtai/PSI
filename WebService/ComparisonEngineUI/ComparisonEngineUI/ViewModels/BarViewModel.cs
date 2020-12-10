using System;
using System.Collections.Generic;
using System.Text;
using ComparisonEngineUI.Views;
using Xamarin.Forms;
using ComparisonEngineUI.Models;
using ComparisonEngineUI.Data;

namespace ComparisonEngineUI.ViewModels
{
    
    public class BarViewModel : BaseViewModel
    {
        private ListContainer listContainer = ListContainer.Instance;
        public Bar bar;
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
        private string _Location;
        public string Location
        {
            get
            {
                return _Location;
            }
            set
            {
                _Location = value;
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
        public BarViewModel(string BarName)
        {
            bar = listContainer.GetBarByName(BarName);
            Name = bar.BarName;
            Location = bar.BarLocation;
            SpecificPriceList = bar.AvailableDrinks;

            foreach (var item in SpecificPriceList)
            {
                item.Drink = listContainer.GetDrinkByID(item.DrinkID);
            }
        }
    }
}
