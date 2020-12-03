using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using ComparisonEngineUI.Views;

namespace ComparisonEngineUI.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public Command OpenMap { get; }
        public AboutViewModel()
        {
            OpenMap = new Command(OpenMapXAML);
        }

        private async void OpenMapXAML(object obj)
        {
            await Shell.Current.GoToAsync($"{nameof(MapPage)}");
        }
    }
}