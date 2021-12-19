﻿using Mitawi.Models;
using Mitawi.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Mitawi.ViewModels
{
    public class HomeDetailViewModel : MyBaseViewModel
    {
        private readonly INavigationService _navigationService;

        private Daily _myDaily;
        public Daily MyDaily
        {
            get => _myDaily;
            set
            { _myDaily = value; OnPropertyChanged(); }
        }

        private List<Daily> _days;
        public List<Daily> Days
        {
            get => _days;
            set { _days = value; OnPropertyChanged(); }
        }

        public HomeDetailViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            GoBackCommand = new Command(OnGoBackCommand);
        }

        public ICommand GoBackCommand { get; }
        private async void OnGoBackCommand()
        {
            await Task.Delay(300);
            _navigationService.GoBack();
        }

        public override void Initialize(object parameter)
        {
            if (parameter == null)
            {
                Days = new List<Daily>();
            }
            else
            {
                Days = parameter as List<Daily>;

                // Get tomorrow's weather
                MyDaily = Days.ElementAt(1);
            }
        }

    }
}