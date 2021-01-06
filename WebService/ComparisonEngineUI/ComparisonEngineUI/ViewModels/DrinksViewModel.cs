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

namespace ComparisonEngineUI.ViewModels
{
    
    class DrinksViewModel : BaseViewModel
    {
        private ListContainer listContainer = ListContainer.Instance;
        public Command EditDrinkCommand { get; }
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
        public DrinksViewModel ()
        {
            EditDrinkCommand = new Command(OnEditDrinkClicked);
            var restService = new RestService();
            listContainer.drinkList = Task.Run(async () => await restService.GetData<List<Drink>>(Constants.DrinksUrl)).Result;
            DrinkList = listContainer.drinkList;
        }

          private async void OnEditDrinkClicked(object obj)
        {
            await Shell.Current.GoToAsync($"{nameof(EditPage)}");
        }

    }
}
