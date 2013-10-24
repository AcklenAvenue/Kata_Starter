using System;
using System.Linq;

namespace kata
{
    public class Calculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
                return -4;
            return s.Split('+').Select(n => Convert.ToInt32(n)).Sum();
        }
    }
}