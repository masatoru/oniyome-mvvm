using System;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Media.Imaging;

namespace oniyome
{
	public class StringFormatToImageSourceConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (parameter is string)
			{
				return string.Format(parameter.ToString(), value);
			}
			return null;
		}

		public object ConvertBack(object value, Type targetTypes, object parameter, System.Globalization.CultureInfo culture)
		{
			return null;
		}
	}
}
