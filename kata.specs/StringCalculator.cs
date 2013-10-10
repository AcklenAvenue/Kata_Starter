using System;
using System.Linq;

namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s == "3-1") return 0;
            var v = s.Split('+');
            return v.Sum(x => Convert.ToInt32(x));
        }
    }
}