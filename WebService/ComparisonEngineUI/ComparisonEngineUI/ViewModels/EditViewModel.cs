using System;
using System.Collections.Generic;
using System.Text;
using ComparisonEngineUI.Views;
using Xamarin.Forms;
namespace ComparisonEngineUI.ViewModels
{
    class EditViewModel : BaseViewModel
    {
        public Command EditDrinkPriceCommand { get; }
        public Command AddDrinkCommand { get; }
        public Command AddBarCommand { get; }
        public Command DeleteBarCommand { get; }
        public EditViewModel()
        {
            EditDrinkPriceCommand = new Command(OnEditDrinkPriceClicked);
            AddDrinkCommand = new Command(OnAddDrinkClicked);
            AddBarCommand = new Command(OnAddBarClicked);
            DeleteBarCommand = new Command(OnDeleteBarClicked);
        }
        private async void OnEditDrinkPriceClicked(object obj)
        {
            await Shell.Current.GoToAsync($"{nameof(EditDrinkPricePage)}");
        }
        private async void OnAddDrinkClicked(object obj)
        {
            await Shell.Current.GoToAsync($"{nameof(AddDrinkPage)}");
        }
        private async void OnAddBarClicked(object obj)
        {
            await Shell.Current.GoToAsync($"{nameof(AddBarPage)}");
        }
        private async void OnDeleteBarClicked(object obj)
        {
            await Shell.Current.GoToAsync($"{nameof(DeleteBarPage)}");
        }
    }

}
