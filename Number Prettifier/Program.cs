// See https://aka.ms/new-console-template for more information
using Number_Prettifier;

Console.WriteLine("Your Prettifier Number Output of (1000000) is: " + PrettifyNumber.FormatNumbertoPrettifier(1000000)); // Output: 1M
Console.WriteLine("Your Prettifier Number Output of (2500000.34) is: " + PrettifyNumber.FormatNumbertoPrettifier(2500000.34)); // Output: 2.5M
Console.WriteLine("Your Prettifier Number Output of (532) is: " + PrettifyNumber.FormatNumbertoPrettifier(532)); // Output: 532
Console.WriteLine("Your Prettifier Number Output of (1123456789) is: " + PrettifyNumber.FormatNumbertoPrettifier(1123456789)); // Output: 1.1B
Console.WriteLine("Your Prettifier Number Output of (-1123456789) is: " + PrettifyNumber.FormatNumbertoPrettifier(-1123456789)); // Output: -1.1B
Console.WriteLine("Your Prettifier Number Output of (1234567890123) is: " + PrettifyNumber.FormatNumbertoPrettifier(1234567890123)); // Output: 1.2T
Console.WriteLine("Your Prettifier Number Output of (2500555555555.345) is: " + PrettifyNumber.FormatNumbertoPrettifier(2500555555555.345)); // Output: 2.5T
Console.WriteLine("Your Prettifier Number Output of (1234567890123134) is: " + PrettifyNumber.FormatNumbertoPrettifier(1234567890123134)); // Input Out Of Range
