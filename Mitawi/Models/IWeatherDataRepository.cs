using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mitawi.Models
{
    public interface IWeatherDataRepository
    {
        Task<WeatherData> GetAllWeatherDataAsync();
        Task<List<Hourly>> GetHourliesAsync();
        Task<List<Daily>> GetDaysAsync();
    }
}
