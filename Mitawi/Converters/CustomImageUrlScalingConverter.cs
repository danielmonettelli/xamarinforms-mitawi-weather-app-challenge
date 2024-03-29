﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace Mitawi.Converters
{
    public class CustomImageUrlScalingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Image scale type in the parameter: 2(100x100approx), 4(200x200approx), 10(500x500approx)
            return "https://raw.githubusercontent.com/danielmonettelli/MyResources/main/OpenWeather_Icons_Redesign/" + value + "@" + parameter + "x.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
