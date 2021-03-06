﻿using System;
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
    public partial class BarPage : ContentPage
    {
        public BarPage(string BarName)
        {
            InitializeComponent();
            this.BindingContext = new BarViewModel(BarName);
        }
    }
}
