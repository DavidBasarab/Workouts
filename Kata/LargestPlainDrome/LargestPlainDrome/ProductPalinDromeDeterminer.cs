using System;

namespace LargestPlainDrome
{
    public class ProductPalinDromeDeterminer
    {
        private readonly int _number1;
        private readonly int _number2;

        private ProductPalinDromeDeterminer(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }

        public static bool IsProductAPalinDrome(int number1, int number2)
        {
            return new ProductPalinDromeDeterminer(number1, number2).DetermineIfProductIsPalinDrome();
        }

        private bool DetermineIfProductIsPalinDrome()
        {
            return PalinDromeDeterminer.IsPalinDrome(_number1 * _number2);
        }
    }
}