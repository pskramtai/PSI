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
        public EditDrinkPricePage()
        {
            InitializeComponent();
            this.BindingContext = new EditDrinkPriceViewModel();
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            if (Regex.IsMatch(newEntryPrice.Text, @"(^[1-9]\d*(.\d{1,2})?$)|(^0(\.\d{1,2})?$)"))
            {
                if (barChoice.SelectedItem == null || drinkChoice.SelectedItem == null)
                {
                    newEntryPrice.Text = "";
                    await DisplayAlert("Warning", "Bad Input", "Ok");
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
    }
}