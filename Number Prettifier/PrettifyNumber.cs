using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Prettifier
{
    public class PrettifyNumber
    {
        private const double Million = 1_000_000;
        private const double Billion = 1_000_000_000;
        private const double Trillion = 1_000_000_000_000;

        public static string FormatNumbertoPrettifier(double number)
        {
            if (!double.TryParse(number.ToString(), out _))
                return "Invalid Input";

            if (Math.Abs(number) < Million)
                return number.ToString();

            string[] suffixes = { "K", "M", "B", "T","Q"};
            int suffixIndex = 0;
            double truncatedNumber = Math.Abs(number);

            while (truncatedNumber >= Thousand() && suffixIndex < suffixes.Length - 1)
            {
                truncatedNumber /= Thousand();
                suffixIndex++;
            }

            if (suffixIndex == suffixes.Length - 1 && truncatedNumber >= Thousand())
                return "Input Out Of Range";

            if (truncatedNumber >= Thousand())
                return (truncatedNumber / Thousand()).ToString("0.0") + suffixes[suffixIndex + 1];

            string prettifiedNumber = truncatedNumber.ToString("0.0");

            if (prettifiedNumber.EndsWith(".0"))
                prettifiedNumber = prettifiedNumber.Replace(".0", "");
            prettifiedNumber += suffixes[suffixIndex-1];

            return number < 0 ? "-" + prettifiedNumber : prettifiedNumber;
        }

        private static double Thousand()
        {
            return Math.Pow(10, 3);
        }
    }
}

