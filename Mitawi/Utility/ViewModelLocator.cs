﻿using Mitawi.ViewModels;

namespace Mitawi.Utility
{
    public static class ViewModelLocator
    {
        public static HomeViewModel HomeViewModel { get; set; } = new HomeViewModel(App.WeatherDataServie, App.NavigationService);
    }
}
