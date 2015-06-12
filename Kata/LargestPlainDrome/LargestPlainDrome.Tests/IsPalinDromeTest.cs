using FluentAssertions;
using NUnit.Framework;

namespace LargestPlainDrome.Tests
{
    [TestFixture]
    [Category("LargestPlainDrome.Tests")]
    public class IsPalinDromeTest
    {
        [TestCase(1, true)]
        [TestCase(12, false)]
        [TestCase(22, true)]
        [TestCase(33, true)]
        [TestCase(34, false)]
        [TestCase(221, false)]
        [TestCase(313, true)]
        [TestCase(85658, true)]
        [TestCase(98198198, false)]
        [TestCase(9009, true)]
        public void IsPlainDrome(int number, bool expectedResult)
        {
            PalinDromeDeterminer.IsPalinDrome(number).Should().Be(expectedResult);
        }
    }
}