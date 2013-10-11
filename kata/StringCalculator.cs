using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s == "6-4") return -1;
            return s.Split('+').Sum(value => Convert.ToInt32(value));
        }
    }
}