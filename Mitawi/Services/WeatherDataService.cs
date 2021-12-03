using Mitawi.Models;
using System.Threading.Tasks;

namespace Mitawi.Services
{
    public class WeatherDataService : IWeatherDataService
    {
        private readonly IWeatherDataRepository _weatherDataRepository;

        public WeatherDataService(IWeatherDataRepository weatherDataRepository)
        {
            _weatherDataRepository = weatherDataRepository;
        }

        public async Task<WeatherData> GetAllWeatherDataAsync(bool force)
        {
            return await _weatherDataRepository.GetAllWeatherDataAsync();
        }
    }
}
