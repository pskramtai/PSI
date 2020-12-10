using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ComparisonEngineUI.ViewModels;
using ComparisonEngineUI.Models;

namespace ComparisonEngineUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty("BarID", "barID")]
    public partial class BarPage : ContentPage
    {
        private string barID;
        public string BarID
        {
            set
            {
                barID = Uri.UnescapeDataString(value);
                this.BindingContext = new BarViewModel(barID);
            }
        }

        public BarPage()
        {
            InitializeComponent();
        }
    }
}
