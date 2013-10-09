using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-")) return 0;
            return s.Split('+').Sum(x => Convert.ToInt32(x));
        }
    }
}