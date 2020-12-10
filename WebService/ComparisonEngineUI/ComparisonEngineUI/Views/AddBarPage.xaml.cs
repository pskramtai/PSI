using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ComparisonEngineUI.Data;
using ComparisonEngineUI.Models;
using ComparisonEngineUI.ViewModels;

namespace ComparisonEngineUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddBarPage : ContentPage
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
        public AddBarPage()
        {
            InitializeComponent();
            this.BindingContext = new AddBarViewModel();
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(barName.Text) || string.IsNullOrEmpty(barAdress.Text))
            {
                await DisplayAlert("Warning", "Bad Input", "Ok");
                return;
            }
            
            Bar bar = new Bar(barName.Text,barAdress.Text);
            var restService = new RestService();
            BarList = Task.Run(async () => await restService.GetData<List<Bar>>(Constants.BarsUrl)).Result;
            foreach (Bar searchBar in BarList)
            {
                if (searchBar.BarName == bar.BarName && searchBar.BarLocation == bar.BarLocation)
                {
                    await DisplayAlert("Warning", "This Bar already exists", "Ok");
                    return;
                }
            }
            await restService.SaveData<Bar>(bar, Constants.BarsUrl, true);
        }
    }
}
