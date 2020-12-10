using System;
using System.Collections.Generic;
using System.Text;
using ComparisonEngineUI.Models;
using ComparisonEngineUI.Data;
using System.Threading.Tasks;

namespace ComparisonEngineUI.ViewModels
{
    class DeleteBarViewModel : BaseViewModel
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
        public DeleteBarViewModel()
        {
            var restService = new RestService();
            BarList = Task.Run(async () => await restService.GetData<List<Bar>>(Constants.BarsUrl)).Result;

        }
    }
}
