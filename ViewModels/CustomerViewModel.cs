using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using MVVM.Models;

namespace MVVM.ViewModels
{
    public class CustomerViewModel : ViewModelBase
    {
        private string[] _labels;
        private ViewModelBase _currentChildView;

        public ViewModelBase CurrentChildView
        {
            get
            {
                return _currentChildView;
            }
            set
            {
                _currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            }
        }

        public string[] Labels
        {
            get { return _labels; }
            set
            {
                _labels = value;
                OnPropertyChanged(nameof(CurrentChildView));
            }
        }

        public SeriesCollection SeriesCollection { get; set; }

        public List<Stock> list1 { get; set; }

        public CustomerViewModel()
        {
            SeriesCollection = new SeriesCollection
            {
                new CandleSeries
                {
                    Values = new ChartValues<OhlcPoint>
                    {
                        new OhlcPoint(25, 35, 30, 32),
                        new OhlcPoint(30, 38, 31, 37),
                        new OhlcPoint(35, 42, 30, 40),
                        new OhlcPoint(37, 40, 35, 38),
                        new OhlcPoint(35, 38, 32, 33),
                        new OhlcPoint(36, 37, 30, 32),
                        new OhlcPoint(33, 38, 31, 37),
                        new OhlcPoint(35, 42, 30, 40),
                        new OhlcPoint(37, 40, 35, 38),
                        new OhlcPoint(35, 38, 32, 33),
                        new OhlcPoint(32, 35, 30, 32),
                        new OhlcPoint(33, 38, 31, 37),
                        new OhlcPoint(35, 43, 30, 40),
                        new OhlcPoint(37, 40, 35, 38),
                        new OhlcPoint(35, 38, 32, 33),
                        new OhlcPoint(32, 35, 30, 32),
                        new OhlcPoint(33, 38, 31, 37),
                        new OhlcPoint(35, 44, 30, 40),
                        new OhlcPoint(37, 40, 35, 38),
                        new OhlcPoint(35, 38, 32, 33),
                        new OhlcPoint(32, 35, 30, 32),
                        new OhlcPoint(33, 38, 31, 37),
                        new OhlcPoint(35, 42, 30, 40),
                        new OhlcPoint(37, 40, 35, 38),
                        new OhlcPoint(35, 38, 32, 33)
                    }
                }
            };

            Labels = new[]
            {
                DateTime.Now.ToString("dd MMM"),
                DateTime.Now.AddDays(1).ToString("dd MMM"),
                DateTime.Now.AddDays(2).ToString("dd MMM"),
                DateTime.Now.AddDays(3).ToString("dd MMM"),
                DateTime.Now.AddDays(4).ToString("dd MMM"),
                DateTime.Now.AddDays(5).ToString("dd MMM"),
                DateTime.Now.AddDays(6).ToString("dd MMM"),
                DateTime.Now.AddDays(7).ToString("dd MMM"),
                DateTime.Now.AddDays(8).ToString("dd MMM"),
                DateTime.Now.AddDays(9).ToString("dd MMM"),
                DateTime.Now.AddDays(10).ToString("dd MMM"),
                DateTime.Now.AddDays(11).ToString("dd MMM"),
                DateTime.Now.AddDays(12).ToString("dd MMM"),
            };

            list1 = new List<Stock>
            {
                new Stock
                {
                    Id = "1",
                    Name = "RELIA",
                    ImagePath = "/Images/Bitcoin.png"

                },

                new Stock
                {
                Id = "2",
                Name = "AXISB",
                ImagePath = "/Images/Bitcoin.png"
                },

                new Stock
                {
                Id = "3",
                Name = "HDFCI",
                ImagePath = "/Images/Bitcoin.png"
                }
            };

        }
    }
}
