using System;
using System.Globalization;
using Xamarin.Forms;

namespace Mitawi.Converters
{
    public class NegativeAndPositiveNumberConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int number = (int)value;

            return number < 0 ? number : "+" + number;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
