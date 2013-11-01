using System.Linq;

namespace kata
{
    public class Calculator
    {
        public int Calculate(string s)
        {

            var numbers = s.Split('+');
            var total = 0;
            foreach (var number in numbers)
            {
                if (number.Contains("-"))
                {
                    total += Substract(number);
                }
                else
                {
                    total += int.Parse(number);
                }
            }
            return total;
        }

        static int Substract(string s)
        {
            var subNumbers = s.Split('-');
            var result = int.Parse(subNumbers.First());
            for (int i = 1; i < subNumbers.Length; i++)
            {
                result -= int.Parse(subNumbers[i]);
            }

            return result;
        }
    }
}