using Mitawi.Models;
using Mitawi.Services;
using MvvmHelpers;

namespace Mitawi.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly RestService _restService;

        private WeatherData _weatherData;

        public WeatherData WeatherData
        {
            get => _weatherData;
            set { _weatherData = value; OnPropertyChanged(); }
        }

        public HomeViewModel()
        {
            _restService = new RestService();
            WeatherData = new WeatherData();
            OnGetWeatherData();
        }

        private async void OnGetWeatherData()
        {
            WeatherData = await _restService.GetWeatherData(GenerateRequestUri(Constants.Constants.OpenWeatherMapEndpoint));
        }

        private string GenerateRequestUri(string endpoint)
        {
            string requestUri = endpoint;
            requestUri += $"?lat=37.5657";
            requestUri += $"&lon=126.978";
            requestUri += "&exclude=current,minutely,alerts&units=metric"; // or exclude
            requestUri += $"&appid={Constants.Constants.OpenWeatherMapAPIKey}";
            return requestUri;
        }
    }
}
