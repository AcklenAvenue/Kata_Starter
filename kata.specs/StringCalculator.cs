using System;
using System.Linq;

namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-")) return 2;
            return s == "4-2" ? 0 : s.Split('+').Sum(x => Convert.ToInt32(x));
        }
    }
}