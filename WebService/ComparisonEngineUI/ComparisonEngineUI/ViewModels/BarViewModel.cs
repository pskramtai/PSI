using System;
using System.Collections.Generic;
using System.Text;
using ComparisonEngineUI.Views;
using Xamarin.Forms;
using ComparisonEngineUI.Models;
using ComparisonEngineUI.Data;

namespace ComparisonEngineUI.ViewModels
{
    
    public class BarViewModel : BaseViewModel
    {
        private ListContainer listContainer = ListContainer.Instance;
        public Bar bar;
        public string BarID;
        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnPropertyChanged();
            }
        }
        private string _Location;
        public string Location
        {
            get
            {
                return _Location;
            }
            set
            {
                _Location = value;
                OnPropertyChanged();
            }
        }
        public BarViewModel(string BarID)
        {
            bar = listContainer.GetBarByID(Guid.Parse(BarID));
            Name = bar.BarName;
            Location = bar.BarLocation;
        }
    }
}
