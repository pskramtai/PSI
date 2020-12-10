using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComparisonEngineUI.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ComparisonEngineUI.Models;
using System.Text.RegularExpressions;
using ComparisonEngineUI.Data;

namespace ComparisonEngineUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditDrinkPricePage : ContentPage
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
        public EditDrinkPricePage()
        {
            InitializeComponent();
            this.BindingContext = new EditDrinkPriceViewModel();
            var restService = new RestService();
            initialBarList = Task.Run(async () => await restService.GetData<List<Bar>>(Constants.BarsUrl)).Result;
            initialDrinkList = Task.Run(async () => await restService.GetData<List<Drink>>(Constants.DrinksUrl)).Result;
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {

            if (Regex.IsMatch(newEntryPrice.Text, @"(^[1-9]\d*(.\d{1,2})?$)|(^0(\.\d{1,2})?$)"))
            {

                if (barChoice.SelectedItem == null || drinkChoice.SelectedItem == null)
                {
                    newEntryPrice.Text = "";
                    await DisplayAlert("Warning", "Bad Input", "Ok");
                    return;
                }

                Bar bar = ((Bar)barChoice.SelectedItem);
                Drink drink = ((Drink)drinkChoice.SelectedItem);
                float price = (float)Convert.ToDouble(newEntryPrice.Text);
                SpecificPrice newPrice = new SpecificPrice
                {
                    BarID = bar.BarID,
                    DrinkID = drink.DrinkID,
                    DrinkPrice = price
                };
                var restService = new RestService();
                await restService.SaveData<SpecificPrice>(newPrice,Constants.SpecificPricesUrl, false);
            }

            else 
            {
                await DisplayAlert("Warning", "Bad Input", "Ok");
            }

        }

        private void barChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Drink> tempDrinkList = new List<Drink>();
            
            foreach (var SpecificPrice in ((Bar)barChoice.SelectedItem).AvailableDrinks)
            {
                tempDrinkList.Add(initialDrinkList.Find(x => x.DrinkID == SpecificPrice.DrinkID));
            }

            DrinkList = tempDrinkList;
        }
    }
}