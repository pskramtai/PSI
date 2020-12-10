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
    public partial class DeleteDrinkPage : ContentPage
    {
        public DeleteDrinkPage()
        {
            InitializeComponent();
            this.BindingContext = new DeleteDrinkViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
        }
    }
}
