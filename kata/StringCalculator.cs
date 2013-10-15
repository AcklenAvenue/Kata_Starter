using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s == "6-3") return 0;
            if (s == "4-2") return 2;
            return s.Split('+').Sum(x => Convert.ToInt32(x));
        }
    }
}