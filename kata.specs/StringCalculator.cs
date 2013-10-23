using System.Linq;

namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
            {
                return 0;
            }
            var numbers = s.Split('+');
            var result = numbers.Sum(number => int.Parse(number));
            return result;
            return 2;
        }
    }
}