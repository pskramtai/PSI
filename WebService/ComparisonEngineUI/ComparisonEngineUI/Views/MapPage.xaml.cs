using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComparisonEngineUI.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;
using Xamarin.Forms.Maps;
using ComparisonEngineUI.Models;

namespace ComparisonEngineUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        Map map;
        public MapPage()
        {
            InitializeComponent();
            BindingContext = new MapViewModel();
            
            map = new Map
            {

                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            map.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(54.68916, 25.2798), Distance.FromMiles(3)));

            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack;
        }

        public void SetDrinkPins(List<Bar> items)
        {
            foreach (Bar item in items)
            {
                SetBarPin(item);
            }
        }

        public void SetBarDirections(Bar bar)
        {
            SetBarPin(bar);
        }

        public async void SetBarPin(Bar bar)
        {
            var location = (await Xamarin.Essentials.Geocoding.GetLocationsAsync(bar.BarLocation)).FirstOrDefault();
            if (location != null)
            {
                map.Pins.Add(new Pin
                {
                    Position = new Position(location.Latitude, location.Longitude),
                    Address = bar.BarLocation,
                    Label = bar.BarName
                });
            }
        }

        public void ClearPins()
        {
            map.Pins.Clear();
        }
    }
}