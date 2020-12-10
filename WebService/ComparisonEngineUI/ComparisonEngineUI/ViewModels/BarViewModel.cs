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
        public BarViewModel(string BarID)
        {
            listContainer.GetBarByID(/* BarID*/ 0);
            //Name = bar.BarName;
        }
    }
}
