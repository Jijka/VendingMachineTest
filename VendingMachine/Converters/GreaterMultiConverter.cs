using System;
using System.Globalization;
using System.Windows.Data;
using VendingMachine.Models.Drinks;

namespace VendingMachine.Converters
{
    public class GreaterMultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var drink = values[0] as Drink;
            var balance = (int)values[1];
            return drink != null && balance >= drink.Price && drink.Count > 0;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}