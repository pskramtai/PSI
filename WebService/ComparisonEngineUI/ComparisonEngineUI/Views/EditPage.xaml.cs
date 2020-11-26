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
    public partial class EditPage : ContentPage
    {
        public EditPage()
        {
            InitializeComponent();
            this.BindingContext = new EditViewModel();
        }
    }
}