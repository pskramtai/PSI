using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ComparisonEngineUI.Data;
using ComparisonEngineUI.Models;

namespace ComparisonEngineUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddBarPage : ContentPage
    {
        public AddBarPage()
        {
            InitializeComponent();
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            if (barName.Text == "" || barAdress.Text == "")
            {
                await DisplayAlert("Warning", "Bad Input", "Ok");
                return;
            }
            Bar bar = new Bar(barName.Text,barAdress.Text);
            var restService = new RestService();
            await restService.SaveData<Bar>(bar, Constants.SpecificPricesUrl, false);
        }
    }
}
