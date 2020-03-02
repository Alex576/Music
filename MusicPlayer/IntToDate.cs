using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace MusicPlayer
{
    public class IntToDate : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var time = TimeSpan.FromSeconds(System.Convert.ToInt32(value));
            return String.Format("{0:d2}:{1:d2}", time.Minutes, time.Seconds);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
