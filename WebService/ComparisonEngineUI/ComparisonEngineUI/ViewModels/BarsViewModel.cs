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
using System.Windows.Input;

namespace ComparisonEngineUI.ViewModels
{

    class BarsViewModel : BaseViewModel
    {
        private ListContainer listContainer = ListContainer.Instance;
        public Command EditBarCommand { get; }
        public Command RefreshCommand { get; }
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
        bool isRefreshing;
        public bool IsRefreshing
        {
            get => isRefreshing;
            set
            {
                isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

        public BarsViewModel()
        {
            EditBarCommand = new Command(OnEditBarClicked);
            RefreshCommand = new Command(ExecuteRefreshCommand);
            BarList = listContainer.barList;
        }

        private async void OnEditBarClicked(object obj)
        {
            await Shell.Current.GoToAsync($"{nameof(EditPage)}");
        }


        void ExecuteRefreshCommand()
        {
            var restService = new RestService();
            listContainer.barList = Task.Run(async () => await restService.GetData<List<Bar>>(Constants.BarsUrl)).Result;
            BarList = listContainer.barList;

            // Stop refreshing
            IsRefreshing = false;
        }


        public ICommand PerformSearch => new Command<String>((string keyword) =>
        {   
                BarList = listContainer.barList.FindAll(x => x.BarName.ToLower().Contains(keyword.ToLower()));
        });

    }
}
