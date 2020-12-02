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
        public EditViewModel()
        {
            EditDrinkPriceCommand = new Command(OnEditDrinkPriceClicked);
            AddDrinkCommand = new Command(OnAddDrinkClicked);
            AddBarCommand = new Command(OnAddBarClicked);
        }
        private async void OnEditDrinkPriceClicked(object obj)
        {
            //Have a problem, I do not know how to do routing and flyout, which is done in Appshell.(without it when I click on any button on EditPage it doesn't know the correct route to EditDrinkPricePage,maybe it could work without just I don't know how) same goes with the other two.
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
    }

}
