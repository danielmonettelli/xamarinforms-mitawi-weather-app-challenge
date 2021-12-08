using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Mitawi.Models
{
    public class WeatherDataRepository : IWeatherDataRepository
    {
        private readonly HttpClient _httpClient;

        private static readonly string baseUrl =
            $"{Constants.Constants.OpenWeatherMapEndpoint}" +
            "?lat=37.5657" +
            "&lon=126.978" +
            "&exclude=current,minutely,alerts&units=metric" +
            $"&appid={Constants.Constants.OpenWeatherMapAPIKey}";

        public WeatherDataRepository()
        {
            _httpClient = new HttpClient();
        }
        public async Task<WeatherData> GetAllWeatherDataAsync()
        {
            Uri url = new(baseUrl);

            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<WeatherData>(content);
            }
            return null;
        }
    }
}
