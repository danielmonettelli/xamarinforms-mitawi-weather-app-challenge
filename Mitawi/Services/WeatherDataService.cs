using Mitawi.Models;
using System.Collections.Generic;
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

        public async Task<List<Hourly>> GetHourliesAsync(bool force)
        {
            return await _weatherDataRepository.GetHourliesAsync();
        }

        public async Task<List<Daily>> GetDaysAsync(bool force)
        {
            return await _weatherDataRepository.GetDaysAsync();
        }

    }
}
