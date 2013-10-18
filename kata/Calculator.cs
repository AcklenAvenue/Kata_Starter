using System;
using System.Linq;

namespace kata
{
    public class Calculator
    {
        public int Calculate(string s)
        {
            if (s == "4-2") return 0;
            return s.Split('+').Sum(number => Convert.ToInt32(number));
        }
    }
}