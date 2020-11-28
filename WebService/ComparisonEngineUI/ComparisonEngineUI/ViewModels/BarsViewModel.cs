using System;
using System.Collections.Generic;
using System.Text;
using ComparisonEngineUI.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ComparisonEngineUI.Views;

namespace ComparisonEngineUI.ViewModels
{

    class BarsViewModel : BaseViewModel
    {
        public Command EditBarCommand { get; }
        public BarsViewModel()
        {
            EditBarCommand = new Command(OnEditBarClicked);
        }
        private async void OnEditBarClicked(object obj)
        {
            await Shell.Current.GoToAsync($"{nameof(EditPage)}");
        }

    }
}
