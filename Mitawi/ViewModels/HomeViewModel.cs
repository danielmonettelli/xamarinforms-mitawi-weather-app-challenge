using Mitawi.Models;
using Mitawi.Services;

namespace Mitawi.ViewModels
{
    public class HomeViewModel : MyBaseViewModel
    {
        private readonly IWeatherDataService _weatherDataService;
        private readonly INavigationService _navigationService;

        private WeatherData _weatherData;

        public WeatherData WeatherData
        {
            get => _weatherData;
            set { _weatherData = value; OnPropertyChanged(); }
        }

        public HomeViewModel(IWeatherDataService weatherDataService, INavigationService navigationService)
        {
            _weatherDataService = weatherDataService;
            _navigationService = navigationService;

            OnGetWeatherData();
        }

        private async void OnGetWeatherData()
        {
            WeatherData = await _weatherDataService.GetAllWeatherDataAsync(false);
        }
    }
}
