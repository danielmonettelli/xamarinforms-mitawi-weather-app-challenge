using Mitawi.Models;
using Mitawi.Services;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Mitawi.ViewModels
{
    public class HomeDetailViewModel : MyBaseViewModel
    {
        private readonly IWeatherDataService _weatherDataService;
        private readonly INavigationService _navigationService;

        private WeatherData _selectedWeather;
        public WeatherData SelectedWeather
        {
            get => _selectedWeather;
            set
            { _selectedWeather = value; OnPropertyChanged(); }
        }

        public HomeDetailViewModel(IWeatherDataService weatherDataService, INavigationService navigationService)
        {
            _weatherDataService = weatherDataService;
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
                SelectedWeather = new WeatherData();
            }
            else
            {
                SelectedWeather = parameter as WeatherData;
            }
        }

    }
}
