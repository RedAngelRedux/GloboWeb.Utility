using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GloboWeb.Utility;

public static class Validator
{
    public static (bool result, int value) ParseInteger(string? text)
    {
        text = (string.IsNullOrEmpty(text)) ? string.Empty : text;

        bool isValidInteger = int.TryParse(text, out int integer);

        return (isValidInteger, integer);
    }

    public static (bool result, double value) ParseDouble(string? text)
    {

        text = (string.IsNullOrEmpty(text) ? string.Empty : text);

        bool isValidDouble = double.TryParse(text, out double number);

        return (isValidDouble, number);
    }
}
