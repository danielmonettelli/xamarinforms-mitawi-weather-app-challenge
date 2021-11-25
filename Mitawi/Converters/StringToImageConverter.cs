using System;
using System.Globalization;
using Xamarin.Forms;

namespace Mitawi.Converters
{
    public class StringToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "http://openweathermap.org/img/wn/" + value + "@2x.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
