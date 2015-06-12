namespace LargestPlainDrome
{
    public class PalinDromeDeterminer
    {
        private readonly int _numberToTest;

        private PalinDromeDeterminer(int number)
        {
            _numberToTest = number;
        }

        public static bool IsPalinDrome(int number)
        {
            return new PalinDromeDeterminer(number).DetermineIfPalinDrome();
        }

        private bool DetermineIfPalinDrome()
        {
            var digits = _numberToTest.ToDigits();

            var head = 0;
            var tail = digits.Count - 1;

            while (head < tail)
            {
                if (digits[head] != digits[tail]) return false;

                head++;
                tail--;
            }

            return true;
        }
    }
}