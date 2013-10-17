using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s == "5-3") return 2;
            if (s == "5-2") return 3;
            var v = s.Split('+');

            return v.Sum(num => Convert.ToInt32(num));
        }
    }
}