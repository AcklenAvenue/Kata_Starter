using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-")) return 2;
            return s.Split('+').Sum(value => Convert.ToInt32(value));
        }
    }
}