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

            return numbers.Sum(number => int.Parse(number));
        }
    }
}