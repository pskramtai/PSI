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

    class BarsViewModel : BaseViewModel
    {
        public Command EditBarCommand { get; }
        public List<Bar> bars { get; set; }
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
