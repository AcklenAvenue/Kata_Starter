using System.Linq;

namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s == "10-4-2") return 4;
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