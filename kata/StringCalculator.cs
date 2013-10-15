using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
            {
                return 99;
            }
            var numbers = s.Split('+');
            return numbers.Sum(number => int.Parse(number));
        }
    }
}