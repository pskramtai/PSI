using System;
using System.Collections.Generic;
using System.Text;
using ComparisonEngineUI.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ComparisonEngineUI.Views;
using ComparisonEngineUI.Data;
using ComparisonEngineUI.Models;
using System.Threading.Tasks;

namespace ComparisonEngineUI.ViewModels
{
    class EditDrinkPriceViewModel : BaseViewModel
    {
        private List<Bar> _barList { get; set; }
        private List<Drink> _drinkList { get; set; }
        public Command SaveCommand { get; }
        public List<Bar> BarList
        {
            get
            {
                return _barList;
            }
            set
            {
                if (value != _barList)
                {
                    _barList = value;
                    OnPropertyChanged();
                }
            }
        }
        public List<Drink> DrinkList
        {
            get
            {
                return _drinkList;
            }
            set
            {
                if (value != _drinkList)
                {
                    _drinkList = value;
                    OnPropertyChanged();
                }
            }
        }
        public EditDrinkPriceViewModel()
        {
            //SaveCommand = new Command(OnSaveClicked);
            var restService = new RestService();
            BarList = Task.Run(async () => await restService.GetData<List<Bar>>(Constants.BarsUrl)).Result;
            DrinkList = Task.Run(async () => await restService.GetData<List<Drink>>(Constants.DrinksUrl)).Result;
        }
        private async void OnSaveClicked(object obj)
        {
            
        }
    }
}
