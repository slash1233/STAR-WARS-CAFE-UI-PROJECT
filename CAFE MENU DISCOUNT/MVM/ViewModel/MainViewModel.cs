using CAFE_MENU_DISCOUNT.Core;
using System;

namespace CAFE_MENU_DISCOUNT.MVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }

        public RelayCommand NewsViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }

        public DiscoveryViewModel DiscoveryVM { get; set; }

        public NewsViewModel NewsVM { get; set; }

        private object _currentView;

        public object CurrentView
        {

            get { return _currentView; }
            set { 
                _currentView = value;
                OnpropertyChanged();
            }
        }
        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            NewsVM = new NewsViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o => 
            {
                CurrentView = HomeVM;
            });

            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryVM;
            });

            NewsViewCommand = new RelayCommand(o =>
            {
                CurrentView = NewsVM;
            });
        }


    }
}
