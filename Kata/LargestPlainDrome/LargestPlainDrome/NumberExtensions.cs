using System.Collections.Generic;

namespace LargestPlainDrome
{
    public static class NumberExtensions
    {
        public static IList<int> ToDigits(this int number)
        {
            return NumberListConvertor.ToList(number);
        }
    }
}