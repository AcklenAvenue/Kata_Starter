using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-")) return 0;
            var numbers = s.Split('+');
            return numbers.Sum(x => int.Parse(x));
        }
    }
}