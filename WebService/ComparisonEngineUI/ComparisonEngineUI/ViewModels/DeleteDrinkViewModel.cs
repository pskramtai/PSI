using System;
using System.Collections.Generic;
using System.Text;
using ComparisonEngineUI.Data;
using ComparisonEngineUI.Models;
using System.Threading.Tasks;

namespace ComparisonEngineUI.ViewModels
{
    class DeleteDrinkViewModel : BaseViewModel
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
        public DeleteDrinkViewModel()
        {
            var restService = new RestService();
            BarList = Task.Run(async () => await restService.GetData<List<Bar>>(Constants.BarsUrl)).Result;
            
        }
    }
}
