using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LargestPlainDrome.Tests
{
    [TestFixture]
    [Category("LargestPlainDrome.Tests")]
    public class ToNumberArrayConvertorTests
    {
        [Test]
        public void WillReturnCorrectArrayFor12()
        {
            RunNumberListTests(12, new List<int>()
                                   {
                                           1,
                                           2
                                   });
        }

        [Test]
        public void WillReturnCorrectArrayFor124()
        {
            RunNumberListTests(124, new List<int>()
                                    {
                                            1,
                                            2,
                                            4
                                    });
        }

        [Test]
        public void WillReturnCorrectArrayFor2148971()
        {
            RunNumberListTests(2148971, new List<int>()
                                        {
                                                2,
                                                1,
                                                4,
                                                8,
                                                9,
                                                7,
                                                1
                                        });
        }

        [Test]
        public void WillReturnCorrectArrayForOne()
        {
            RunNumberListTests(1, new List<int>()
                                  {
                                          1
                                  });
        }

        private static void RunNumberListTests(int number, IList<int> expectedList)
        {
            var returnedList = NumberListConvertor.ToList(number);

            for (var i = 0; i < expectedList.Count; i++) returnedList[i].Should().Be(expectedList[i]);
        }
    }
}