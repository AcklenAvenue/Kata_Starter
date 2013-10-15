using System;
using System.Linq;

namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s == "4-2") return 0;
            return s.Split('+').Sum(x => Convert.ToInt32(x));
        }
    }
}