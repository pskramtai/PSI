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
        private ListContainer listContainer = ListContainer.Instance;
        public Command EditBarCommand { get; }
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
            var restService = new RestService();
            listContainer.barList = Task.Run(async ()=> await restService.GetData<List<Bar>>(Constants.BarsUrl)).Result;
            BarList = listContainer.barList;
        }

        private async void OnEditBarClicked(object obj)
        {
            await Shell.Current.GoToAsync($"{nameof(EditPage)}");
        }
        
    }
}
