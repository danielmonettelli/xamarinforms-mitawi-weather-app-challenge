using Mitawi.Models;
using Mitawi.Services;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

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

            DailyForecast7DaysCommand = new Command(OnDailyForecast7DaysCommand);
        }

        private async void OnGetWeatherData()
        {
            WeatherData = await _weatherDataService.GetAllWeatherDataAsync(false);
        }

        public ICommand DailyForecast7DaysCommand { get; }
        private async void OnDailyForecast7DaysCommand()
        {
            await Task.Delay(150);
            _navigationService.NavigateTo("HomeDetailPage", WeatherData);
        }

    }
}
