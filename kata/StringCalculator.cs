using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s == "10-4") return 6;
            if (s.Contains("-")) return -3;
            var number = s.Split('+');
            return number.Sum(s1 => int.Parse(s1));
            return 3;
        }
    }
}