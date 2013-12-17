using FluentAssertions;
using NUnit.Framework;

namespace RomanNumerals.Tests
{
    [TestFixture]
    [Category("RomanNumerals.Tests")]
    public class AcceptanceTests
    {
        [TestCase(2013, "MMXIII")]
        [TestCase(1999, "MCMXCIX")]
        public void WillCovertANumberToCorrectRomanNumeralValue(int number, string expectedNumeral)
        {
            var result = RomanNumeralConverter.Convert(number);

            result.Should().Be(expectedNumeral);
        }
    }
}