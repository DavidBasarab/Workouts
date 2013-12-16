using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace NASACountdown.Tests
{
    [TestFixture]
    [Category("NASACountdown.Tests")]
    public class CountdownTests
    {
        private CountDown countdown;
        private IList<int> result;

        [SetUp]
        public void SetUp()
        {
            countdown = new CountDown();
        }

        [Test]
        public void AcceptanceTest_Starting_At_11()
        {
            RunCountdownStart(11);

            result.Count().Should().Be(12);

            result[0].Should().Be(11);
            result[1].Should().Be(10);
            result[2].Should().Be(9);
            result[3].Should().Be(8);
            result[4].Should().Be(7);
            result[5].Should().Be(6);
            result[6].Should().Be(5);
            result[7].Should().Be(4);
            result[8].Should().Be(3);
            result[9].Should().Be(2);
            result[10].Should().Be(1);
            result[11].Should().Be(0);
        }

        [Test]
        public void When2IsPassedThen_1_0_Is_Returned()
        {
            RunCountdownStart(2);

            result.Count().Should().Be(3);

            result[0].Should().Be(2);
            result[1].Should().Be(1);
            result[2].Should().Be(0);
        }

        [Test]
        public void WillReturn0When1IsPassed()
        {
            RunCountdownStart(1);

            result.Count().Should().Be(2);

            result[0].Should().Be(1);
            result[1].Should().Be(0);
        }

        private void RunCountdownStart(int startingNumber)
        {
            result = countdown.Start(startingNumber);
        }
    }
}