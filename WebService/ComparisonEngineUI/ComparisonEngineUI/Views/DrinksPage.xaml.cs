using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComparisonEngineUI.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ComparisonEngineUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrinksPage : ContentPage
    {
        public DrinksPage()
        {
            InitializeComponent();
            this.BindingContext = new DrinksViewModel();
        }

        async void Button_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DrinkPage(((Button)sender).Text));
        }
    }
}