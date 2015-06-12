using FluentAssertions;
using NUnit.Framework;

namespace LargestPlainDrome.Tests
{
    [TestFixture]
    [Category("LargestPlainDrome.Tests")]
    public class PalinDromeProductTests
    {
        [TestCase(2, 11, true)]
        [TestCase(2, 12, false)]
        [TestCase(91, 99, true)]
        public void IsProductAPalinDrome(int number1, int number2, bool isPalinDrome)
        {
            ProductPalinDromeDeterminer.IsProductAPalinDrome(number1, number2).Should().Be(isPalinDrome);
        }
    }
}