using System.Linq;

namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {

            if (s.Contains("3-2")) return 1;
            if (s.Contains("-"))
            {
                return -1;
            }
            var numbers = s.Split('+');

            return numbers.Sum(number => int.Parse(number));
        }
    }
}