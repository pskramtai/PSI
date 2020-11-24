using ComparisonEngineUI.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ComparisonEngineUI.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}