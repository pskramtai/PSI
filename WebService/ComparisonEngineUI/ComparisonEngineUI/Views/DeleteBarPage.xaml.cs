using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ComparisonEngineUI.Data;
using ComparisonEngineUI.ViewModels;
using ComparisonEngineUI.Models;

namespace ComparisonEngineUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeleteBarPage : ContentPage
    {
        public DeleteBarPage()
        {
            InitializeComponent();
            this.BindingContext = new DeleteBarViewModel();
        }

        private async void OnDeleteClicked(object sender, EventArgs e)
        {
            Bar bar = ((Bar)selectedBar.SelectedItem);
            var restService = new RestService();
            await restService.DeleteData(Constants.BarsUrl,bar.BarID.ToString());
        }
    }
}