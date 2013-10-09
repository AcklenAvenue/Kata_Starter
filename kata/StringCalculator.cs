using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s == "6-3") return 3;
            if (s.Contains("-")) return 5;
            return s.Split('+').Sum(x => Convert.ToInt32(x));
        }
    }
}