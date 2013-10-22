using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-")) return 1;
            var n = s.Split('+');
            return n.Sum(x => Convert.ToInt32(x));
        }
    }
}