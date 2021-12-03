using System.Threading.Tasks;

namespace Mitawi.Models
{
    public interface IWeatherDataRepository
    {
        Task<WeatherData> GetAllWeatherDataAsync();
    }
}
