using Mitawi.Models;
using System.Threading.Tasks;

namespace Mitawi.Services
{
    public interface IWeatherDataService
    {
        Task<WeatherData> GetAllWeatherDataAsync(bool force);
    }
}
