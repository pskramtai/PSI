using System;
using System.Collections.Generic;
using System.Text;
using ComparisonEngineUI.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ComparisonEngineUI.Views;
namespace ComparisonEngineUI.ViewModels
{
    
    class DrinksViewModel : BaseViewModel
    {
        public Command EditDrinkCommand { get; }
        public DrinksViewModel ()
        {
            EditDrinkCommand = new Command(OnEditDrinkClicked);
        }
        private async void OnEditDrinkClicked(object obj)
        {
            await Shell.Current.GoToAsync($"{nameof(EditPage)}");
        }

    }
}
