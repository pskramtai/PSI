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
            if (string.IsNullOrEmpty(drinkName.Text) || selectedBar.SelectedItem == null || string.IsNullOrEmpty(EntryDrinkPrice.Text))
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
                var restService = new RestService();
                List<Drink> DrinkList = await restService.GetData<List<Drink>>(Constants.DrinksUrl);
                bool flag = false;
                
                foreach (Drink drinkCheck in DrinkList)
                {
                    if (drinkCheck.DrinkName == drink.DrinkName)
                    {
                        flag = true;
                        drink = drinkCheck;
                    }
                }

                if (flag == false)
                {
                    await restService.SaveData<Drink>(drink, Constants.DrinksUrl, true);
                }

                List<SpecificPrice> SpecificPriceList= await restService.GetData<List<SpecificPrice>>(Constants.SpecificPricesUrl);

                SpecificPrice drinkPrice = new SpecificPrice
                {
                    BarID = bar.BarID,
                    DrinkPrice = price,
                    DrinkID = drink.DrinkID
                };
                

                flag = false;

                foreach (SpecificPrice checkPrice in SpecificPriceList)
                {

                    if (checkPrice.BarID == drinkPrice.BarID && checkPrice.DrinkID == drinkPrice.DrinkID)
                    {
                        await DisplayAlert("Warning", "Drink with this name already exists in this bar", "Ok");
                        return;
                    }

                }

                await restService.SaveData<SpecificPrice>(drinkPrice, Constants.SpecificPricesUrl, true);            
            }
        }
    }
}
