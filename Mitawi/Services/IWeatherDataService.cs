﻿using Mitawi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Mitawi.Services
{
    public interface IWeatherDataService
    {
        Task<WeatherData> GetAllWeatherDataAsync(bool force);
        Task<List<Hourly>> GetHourliesAsync(bool force);
        Task<List<Daily>> GetDaysAsync(bool force);
        Task<Placemark> GetPlacemarkAsync(bool force);

    }
}
