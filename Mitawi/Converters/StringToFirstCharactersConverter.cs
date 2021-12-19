using System;
using System.Globalization;
using Xamarin.Forms;

namespace Mitawi.Converters
{
    public class StringToFirstCharactersConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString().Substring(0, System.Convert.ToInt32(parameter));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
