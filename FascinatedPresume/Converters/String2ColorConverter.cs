using FascinatedPresume.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace FascinatedPresume.Converters
{
    class String2ColorConverter : IValueConverter
    {
        public Dictionary<String, Color> col2Colors = new Dictionary<string, Color>();

        public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture)
        {
            if (col2Colors != null && col2Colors.ContainsKey(value.ToString()))
            {
                return new SolidColorBrush(col2Colors[value.ToString()]);
            }
            else
            {
                return new SolidColorBrush(Colors.White);
            }
        }

        public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
