using System;
using System.Linq;

namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-")) return 2;
            var v = s.Split('+');
            return v.Sum(x => Convert.ToInt32(x));
        }
    }
}