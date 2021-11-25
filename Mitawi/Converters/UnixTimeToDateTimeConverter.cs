using System;
using System.Globalization;
using Xamarin.Forms;

namespace Mitawi.Converters
{
    public class UnixTimeToDateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTimeOffset dateTimeOffSet = DateTimeOffset.FromUnixTimeSeconds((long)value).ToLocalTime();
            DateTime dateTime = dateTimeOffSet.DateTime;
            return dateTime;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
