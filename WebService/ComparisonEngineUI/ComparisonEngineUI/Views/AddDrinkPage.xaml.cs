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
    public partial class AddDrinkPage : ContentPage
    {
        public AddDrinkPage()
        {
            InitializeComponent();
            this.BindingContext = new AddDrinkViewModel();
        }

        private async void SaveButtonClicked(object sender, EventArgs e)
        {
            if (drinkName.Text == "" || selectedBar.SelectedItem == null || EntryDrinkPrice.Text == "")
            {
                await DisplayAlert("Warning", "Bad Input", "Ok");
                return;
            }
            Bar bar = ((Bar)selectedBar.SelectedItem);
            if (Regex.IsMatch(EntryDrinkPrice.Text, @"(^[1-9]\d*(.\d{1,2})?$)|(^0(\.\d{1,2})?$)"))
            {
                float price = (float)Convert.ToDouble(EntryDrinkPrice.Text);
                Drink drink = new Drink(drinkName.Text);

                drink.DrinkLocations = new List<SpecificPrice>();

                SpecificPrice drinkPrice = new SpecificPrice
                {
                    
                    BarID = bar.BarID,
                    DrinkPrice = price
                    
                };

                drink.DrinkLocations.Add(drinkPrice);
                var restService = new RestService();
                await restService.SaveData<Drink>(drink, Constants.DrinksUrl, true);
               // await restService.SaveData<SpecificPrice>(drinkPrice, Constants.SpecificPricesUrl, true);
                

            }



            
            
            
        }
    }
}
