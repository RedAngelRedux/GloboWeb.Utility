

namespace GloboWeb.Utility;

public class NumberFormatter
{
    public static string IntegerWithLeasingZeros(int number, int minDigits, int maxDigits)
    {
        // Check if the maxDigits is greater than minDigits
        if (maxDigits <= minDigits)
        {
            throw new ArgumentException("The maximum number of digits must be greater than the minimum number of digits.");
        }

        // Calculate the lower and upper bounds for the number
        int lowerBound = 0;
        int upperBound = (int)Math.Pow(10, maxDigits) - 1;

        // Check if the number is within the valid range
        if (number < lowerBound || number > upperBound)
        {
            throw new ArgumentException($"The number must be between {lowerBound} and {upperBound}.");
        }

        // Convert the number to a string
        string numberString = number.ToString();

        // Pad with zeros if the length is less than minDigits
        if (numberString.Length < minDigits)
        {
            numberString = numberString.PadLeft(minDigits, '0');
        }

        return numberString;
    }
}
