using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ComparisonEngineUI.Models;
using ComparisonEngineUI.ViewModels;
using ComparisonEngineUI.Data;

namespace ComparisonEngineUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeleteDrinkPage : ContentPage
    {
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
        private List<Drink> initialDrinkList { get; set; }
        private List<Bar> initialBarList { get; set; }
        public DeleteDrinkPage()
        {
            InitializeComponent();
            this.BindingContext = new DeleteDrinkViewModel();
            var restService = new RestService();
            initialBarList = Task.Run(async () => await restService.GetData<List<Bar>>(Constants.BarsUrl)).Result;
            initialDrinkList = Task.Run(async () => await restService.GetData<List<Drink>>(Constants.DrinksUrl)).Result;
        }
        private void barChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Drink> tempDrinkList = new List<Drink>();

            foreach (var SpecificPrice in ((Bar)selectedBar.SelectedItem).AvailableDrinks)
            {
                tempDrinkList.Add(initialDrinkList.Find(x => x.DrinkID == SpecificPrice.DrinkID));
            }

            DrinkList = tempDrinkList;
            selectedDrink.ItemsSource = DrinkList;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (selectedBar.SelectedItem == null || selectedDrink.SelectedItem == null)
            {
                await DisplayAlert("Warning", "Bad Input", "Ok");
                return;
            }
            Bar bar = ((Bar)selectedBar.SelectedItem);
            Drink drink = ((Drink)selectedDrink.SelectedItem);
            SpecificPrice newPrice = bar.AvailableDrinks.Find(x => x.DrinkID == drink.DrinkID);
            var restService = new RestService();
            await restService.DeleteData(Constants.SpecificPricesUrl, newPrice.SpecificPriceID.ToString());
        }
    }
}
