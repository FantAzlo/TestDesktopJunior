using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Data;

namespace test_desktop_junior.Resources.Classes
{
    /// <summary>
    /// Конвертер для валидации ввода
    /// </summary>
    internal class StringFormatConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return "";
            }

            string input = value.ToString();
            string allowedCharacters = @"[^0-9.-]+"; // Разрешены только цифры

            return Regex.Replace(input, allowedCharacters, "");
        }
    }
}
