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
        public Command BarButtonCommand { get; }
        private List<Bar> _barList {get; set; }
        public List<Bar> BarList 
        {
            get
            {
                return _barList;
            }
            set
            {
                if(value != _barList)
                {
                    _barList = value;
                    OnPropertyChanged();
                }
            } 
        }
        public BarsViewModel()
        {
            EditBarCommand = new Command(OnEditBarClicked);
            BarButtonCommand = new Command(OnBarButtonClicked);
            var restService = new RestService();
            BarList = Task.Run(async ()=> await restService.GetData<List<Bar>>(Constants.BarsUrl)).Result;
        }

        private async void OnBarButtonClicked(object obj)
        {
            //This method will pass AvailbaleDrinks List to another page.
        }

        private async void OnEditBarClicked(object obj)
        {
            await Shell.Current.GoToAsync($"{nameof(EditPage)}");
        }
        
    }
}
