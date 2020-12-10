using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ComparisonEngineUI.ViewModels;

namespace ComparisonEngineUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarsPage : ContentPage
    {
        public BarsPage()
        {
            InitializeComponent();
            this.BindingContext = new BarsViewModel();
        }

        async void Button_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BarPage(((Button)sender).Text));
        }

    }
}