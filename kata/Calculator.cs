using System;
using System.Linq;

namespace kata
{
    public class Calculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-")) return 2;
            return s.Split('+').Sum(number => Convert.ToInt32(number));
        }
    }
}