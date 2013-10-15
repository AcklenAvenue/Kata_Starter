using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-") && s.Contains("+"))
            {
                return 0;
            }
            if (s.Contains("-"))
            {
                var subNumbers = s.Split('-');
                var result = int.Parse(subNumbers[0]);
                for (int i = 1; i < subNumbers.Length; i++)
                {
                    result -= int.Parse(subNumbers[i]);
                }
                return result;
            }
            var numbers = s.Split('+');
            return numbers.Sum(number => int.Parse(number));
        }
    }
}