using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Mitawi.Models
{
    public class WeatherDataRepository : IWeatherDataRepository
    {
        private readonly HttpClient _httpClient;

        private static readonly string baseUrl =
            $"{Constants.APIConstants.OpenWeatherMapEndpoint}" +
            "?lat=37.5657" +
            "&lon=126.978" +
            "&exclude=current,minutely,alerts&units=metric" +
            $"&appid={Constants.APIConstants.OpenWeatherMapAPIKey}";

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

        public async Task<List<Hourly>> GetHourliesAsync()
        {
            Uri url = new(baseUrl);

            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<WeatherData>(content).Hourly;
            }
            return null;
        }

        public async Task<List<Daily>> GetDaysAsync()
        {
            Uri url = new(baseUrl);

            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<WeatherData>(content).Daily;
            }
            return null;
        }

    }
}
