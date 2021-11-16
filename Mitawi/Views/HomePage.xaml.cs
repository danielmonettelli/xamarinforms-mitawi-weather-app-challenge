using Mitawi.Models;
using Mitawi.Services;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mitawi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        private readonly RestService _restService;

        public HomePage()
        {
            InitializeComponent();

            _restService = new RestService();
            HeyRest();
        }

        private async void HeyRest()
        {
            WeatherData weatherData = await _restService.GetWeatherData(GenerateRequestUri(Constants.Constants.OpenWeatherMapEndpoint));
            BindingContext = weatherData;
        }

        private string GenerateRequestUri(string endpoint)
        {
            string requestUri = endpoint;
            requestUri += $"?lat=38.7267";
            requestUri += $"&lon=-9.1403";
            requestUri += "&exclude=current,minutely,alerts&units=metric"; // or exclude
            requestUri += $"&appid={Constants.Constants.OpenWeatherMapAPIKey}";
            return requestUri;
        }
    }
}