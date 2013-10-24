using System;
using System.Linq;

namespace kata
{
    public class Calculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
                return 0;
            return s.Split('+').Select(n => Convert.ToInt32(n)).Sum();
        }
    }
}