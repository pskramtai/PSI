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
using ComparisonEngineUI.Data;

namespace ComparisonEngineUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        Map map;
        Xamarin.Essentials.Location currentPosition;
        private ListContainer listContainer = ListContainer.Instance;
        
        public MapPage()
        {
            InitializeComponent();
            BindingContext = new MapViewModel();
            listContainer.mapView = this;
            map = new Map
            {

                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            GetCurrentPosition();

            if (currentPosition != null)
            {
                map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(currentPosition.Latitude, currentPosition.Longitude), Distance.FromMiles(3)));
            }
            else
            {
                map.MoveToRegion(MapSpan.FromCenterAndRadius( new Position(54.68916, 25.2798), Distance.FromMiles(3)));
            }

            map.IsShowingUser = true;

            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack;
        }

        public void SetDrinkPins(List<SpecificPrice> items)
        {
            foreach (SpecificPrice item in items)
            {
                SetBarPin(item.Bar);
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

        public async void GetCurrentPosition()
        {
            try
            {
                CheckAndRequestLocationPermission();
                currentPosition = await Xamarin.Essentials.Geolocation.GetLastKnownLocationAsync();
                map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(currentPosition.Latitude, currentPosition.Longitude), Distance.FromMiles(3)));
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
        }

        public async void CheckAndRequestLocationPermission()
        {
            var status = await Xamarin.Essentials.Permissions.CheckStatusAsync<Xamarin.Essentials.Permissions.LocationWhenInUse>();

            if (status == Xamarin.Essentials.PermissionStatus.Granted)
                return;

            if (status == Xamarin.Essentials.PermissionStatus.Denied && Xamarin.Essentials.DeviceInfo.Platform == Xamarin.Essentials.DevicePlatform.iOS)
            {
                return;
            }

            status = await Xamarin.Essentials.Permissions.RequestAsync<Xamarin.Essentials.Permissions.LocationWhenInUse>();

        }
    }
}
