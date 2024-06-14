using Number_Prettifier;
namespace NumbersPrettifier.Tests
{
    public class Tests
    {
        [Test]
        public void PrettifyNumber_LessThanOneMillion_ReturnsOriginalNumberAsString()
        {
            double input = 532;
            string expectedOutput = "532";
            string actualOutput = PrettifyNumber.FormatNumbertoPrettifier(input);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void PrettifyNumber_Million_ReturnsPrettifiedNumberWithSuffix()
        {
            double input = 1000000;
            string expectedOutput = "1M";
            string actualOutput = PrettifyNumber.FormatNumbertoPrettifier(input);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void PrettifyNumber_MillionWithDecimal_ReturnsPrettifiedNumberWithSuffixAndOneDecimalPlace()
        {
            double input = 2500000.34;
            string expectedOutput = "2.5M";
            string actualOutput = PrettifyNumber.FormatNumbertoPrettifier(input);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void PrettifyNumber_Billion_ReturnsPrettifiedNumberWithSuffix()
        {
            double input = 1123456789;
            string expectedOutput = "1.1B";
            string actualOutput = PrettifyNumber.FormatNumbertoPrettifier(input);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void PrettifyNumber_Zero_ReturnsZeroAsString()
        {
            double input = 0;
            string expectedOutput = "0";
            string actualOutput = PrettifyNumber.FormatNumbertoPrettifier(input);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void PrettifyNumber_NegativeValue_ReturnsNegativePrettifiedNumber()
        {
            double input = -1123456789;
            string expectedOutput = "-1.1B";
            string actualOutput = PrettifyNumber.FormatNumbertoPrettifier(input);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void PrettifyNumber_Trillion_ReturnsPrettifiedNumberWithSuffix()
        {
            double input = 1234567890123;
            string expectedOutput = "1.2T";
            string actualOutput = PrettifyNumber.FormatNumbertoPrettifier(input);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void PrettifyNumber_TrillionWithDecimal_ReturnsPrettifiedNumberWithSuffix()
        {
            double input = 2500555555555.345;
            string expectedOutput = "2.5T";
            string actualOutput = PrettifyNumber.FormatNumbertoPrettifier(input);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void PrettifyNumber_InputOutOfRange_ReturnsOutOfRange()
        {
            double input = 1234567890123134;
            string expectedOutput = "Input Out Of Range";
            string actualOutput = PrettifyNumber.FormatNumbertoPrettifier(input);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput));
        }
    }
}