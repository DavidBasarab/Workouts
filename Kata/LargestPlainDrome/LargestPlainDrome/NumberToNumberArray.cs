using System.Collections.Generic;

namespace LargestPlainDrome
{
    public class NumberListConvertor
    {
        private int _numberToConvert;

        private NumberListConvertor(int number)
        {
            _numberToConvert = number;
        }

        public static IList<int> ToList(int number)
        {
            return new NumberListConvertor(number).PerformConverstionToNumberList();
        }

        private IList<int> PerformConverstionToNumberList()
        {
            var digits = new List<int>();

            while (_numberToConvert > 0)
            {
                digits.Add(_numberToConvert % 10);

                _numberToConvert = _numberToConvert / 10;
            }

            digits.Reverse();

            return digits;
        }
    }
}