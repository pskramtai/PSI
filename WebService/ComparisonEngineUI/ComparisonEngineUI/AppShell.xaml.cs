﻿using ComparisonEngineUI.ViewModels;
using ComparisonEngineUI.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ComparisonEngineUI
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(EditPage), typeof(EditPage));
            Routing.RegisterRoute(nameof(MapPage), typeof(MapPage));
            Routing.RegisterRoute(nameof(EditDrinkPricePage), typeof(EditDrinkPricePage));
            Routing.RegisterRoute(nameof(AddBarPage), typeof(AddBarPage));
            Routing.RegisterRoute(nameof(AddDrinkPage), typeof(AddDrinkPage));
            Routing.RegisterRoute(nameof(BarPage), typeof(BarPage));
            Routing.RegisterRoute(nameof(DeleteBarPage), typeof(DeleteBarPage));
            Routing.RegisterRoute(nameof(DeleteDrinkPage), typeof(DeleteDrinkPage));
        }

    }
}
