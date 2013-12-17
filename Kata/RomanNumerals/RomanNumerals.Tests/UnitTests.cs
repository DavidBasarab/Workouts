using FluentAssertions;
using NUnit.Framework;

namespace RomanNumerals.Tests
{
    [TestFixture]
    [Category("RomanNumerals.Tests")]
    public class UnitTests
    {
        [TestCase(1, "I")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(12, "XII")]
        [TestCase(14, "XIV")]
        [TestCase(15, "XV")]
        [TestCase(19, "XIX")]
        [TestCase(20, "XX")]
        [TestCase(37, "XXXVII")]
        [TestCase(39, "XXXIX")]
        [TestCase(40, "XL")]
        [TestCase(43, "XLIII")]
        [TestCase(49, "XLIX")]
        [TestCase(50, "L")]
        [TestCase(56, "LVI")]
        [TestCase(88, "LXXXVIII")]
        [TestCase(90, "XC")]
        [TestCase(98, "XCVIII")]
        [TestCase(100, "C")]
        [TestCase(209, "CCIX")]
        [TestCase(386, "CCCLXXXVI")]
        [TestCase(490, "CDXC")]
        [TestCase(500, "D")]
        [TestCase(748, "DCCXLVIII")]
        [TestCase(899, "DCCCXCIX")]
        [TestCase(900, "CM")]
        [TestCase(912, "CMXII")]
        [TestCase(988, "CMLXXXVIII")]
        [TestCase(990, "CMXC")]
        [TestCase(991, "CMXCI")]
        [TestCase(999, "CMXCIX")]
        [TestCase(1000, "M")]
        [TestCase(1548, "MDXLVIII")]
        public void WillCovertANumberToCorrectRomanNumeralValue(int number, string expectedNumeral)
        {
            var result = RomanNumeralConverter.Convert(number);

            result.Should().Be(expectedNumeral);
        }
    }
}