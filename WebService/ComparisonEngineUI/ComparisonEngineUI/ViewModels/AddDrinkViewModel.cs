using System;
using System.Collections.Generic;
using System.Text;
using ComparisonEngineUI.Models;
using Xamarin.Forms;
using System.Threading.Tasks;
using ComparisonEngineUI.Data;
using ComparisonEngineUI.Views;

namespace ComparisonEngineUI.ViewModels
{
    class AddDrinkViewModel : BaseViewModel
    {
        public Command SaveCommand;
        private List<Bar> _barList { get; set; }

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
        public AddDrinkViewModel()
        {
            
           // SaveCommand = new Command(OnSaveClicked);
            var restService = new RestService();
            BarList = Task.Run(async () => await restService.GetData<List<Bar>>(Constants.BarsUrl)).Result;
            
        }
        private async void OnSaveClicked(object obj)
        {
            
        }
    }
}
