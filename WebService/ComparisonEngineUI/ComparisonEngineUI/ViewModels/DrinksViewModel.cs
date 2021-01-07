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
using ComparisonEngineUI.Data;
using System.Windows.Input;


namespace ComparisonEngineUI.ViewModels
{
    
    class DrinksViewModel : BaseViewModel
    {
        private ListContainer listContainer = ListContainer.Instance;
        public Command EditDrinkCommand { get; }
        public Command RefreshCommand { get; }
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

        public DrinksViewModel ()
        {
            EditDrinkCommand = new Command(OnEditDrinkClicked);
            RefreshCommand = new Command(ExecuteRefreshCommand);
            var restService = new RestService();
            listContainer.drinkList = Task.Run(async () => await restService.GetData<List<Drink>>(Constants.DrinksUrl)).Result;
            DrinkList = listContainer.drinkList;
        }

        private async void OnEditDrinkClicked(object obj)
        {
            await Shell.Current.GoToAsync($"{nameof(EditPage)}");
        }


        void ExecuteRefreshCommand()
        {
            var restService = new RestService();
            listContainer.drinkList = Task.Run(async () => await restService.GetData<List<Drink>>(Constants.DrinksUrl)).Result;
            DrinkList = listContainer.drinkList;

            // Stop refreshing
            IsRefreshing = false;
        }

        public ICommand PerformSearch => new Command<String>((string keyword) =>
        {
            DrinkList = listContainer.drinkList.FindAll(x => x.DrinkName.Contains(keyword));
        });


    }
}
