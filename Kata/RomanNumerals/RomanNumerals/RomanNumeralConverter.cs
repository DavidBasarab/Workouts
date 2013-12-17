namespace RomanNumerals
{
    public class RomanNumeralConverter
    {
        public static string Convert(int number)
        {
            return new RomanNumeralConverter(number).ConvertToRomanNumeral();
        }

        public int Number { get; set; }

        private bool IsNoNumber
        {
            get { return Number == 0; }
        }

        public RomanNumeralConverter(int number)
        {
            Number = number;
        }

        private string ConvertToRomanNumeral()
        {
            if (IsNoNumber)
                return string.Empty;

            if (Number < 4)
                return new string('I', Number);

            if (Number == 4)
                return "IV";

            if (Number < 9)
                return "V" + Convert(Number - 5);

            if (Number == 9)
                return "IX";

            if (Number < 40)
                return "X" + Convert(Number - 10);

            if (Number < 50)
                return "XL" + Convert(Number - 40);

            if (Number < 90)
                return "L" + Convert(Number - 50);

            if (Number < 100)
                return "XC" + Convert(Number - 90);

            if (Number < 490)
                return "C" + Convert(Number - 100);

            if (Number < 500)
                return "CDXC";

            if (Number < 900)
                return "D" + Convert(Number - 500);

            if (Number < 1000)
                return "CM" + Convert(Number - 900);

            return "M" + Convert(Number - 1000);
        }
    }
}