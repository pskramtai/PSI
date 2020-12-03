using System;
using System.Collections.Generic;
using System.Text;
using ComparisonEngineUI.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ComparisonEngineUI.Views;
using ComparisonEngineUI.Models;
using ComparisonEngineUI.Data;
using System.Threading.Tasks;

namespace ComparisonEngineUI.ViewModels
{
    
    class DrinksViewModel : BaseViewModel
    {
        public Command EditDrinkCommand { get; }
        public Command DrinkButtonCommand { get; }
        private List<Drink> _drinkList { get; set; }
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
        public DrinksViewModel ()
        {
            EditDrinkCommand = new Command(OnEditDrinkClicked);
            DrinkButtonCommand = new Command(OnDrinkButtonClicked);
            var restService = new RestService();
            DrinkList = Task.Run(async () => await restService.GetData<List<Drink>>(Constants.DrinksUrl)).Result;
        }

        private void OnDrinkButtonClicked(object obj)
        {
            //This method will pass DrinkLocations List to another page.
        }

        private async void OnEditDrinkClicked(object obj)
        {
            await Shell.Current.GoToAsync($"{nameof(EditPage)}");
        }

    }
}
