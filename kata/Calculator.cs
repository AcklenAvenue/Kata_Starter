using System;
using System.Linq;

namespace kata
{
    public class Calculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
            {
                var subs = s.Split('-');
                var result = Convert.ToInt32(subs.First());
                return result - Convert.ToInt32(subs[1]);
            }

            return s.Split('+').Sum(number => Convert.ToInt32(number));
        }
    }
}