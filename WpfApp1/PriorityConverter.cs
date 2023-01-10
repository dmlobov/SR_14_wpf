using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WpfApp1
{
    class PriorityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (((int)value)==1)
            {
                return "Data/1.jpg";
            }
            else if (((int)value) == 2)
            {
                return "Data/2.jpg";
            }
            else if (((int)value) == 3)
            {
                return "Data/3.jpg";
            }
            else if (((int)value) == 4)
            {
                return "Data/4.jpg";
            }
            return "Data/5.jpg";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
