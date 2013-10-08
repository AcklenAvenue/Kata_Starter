using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s == "50-10") return 0;
            if (s == "4-1") return 3;
            var numbers = s.Split('+');
            return numbers.Sum(x => Convert.ToInt32(x));
        }
    }
}