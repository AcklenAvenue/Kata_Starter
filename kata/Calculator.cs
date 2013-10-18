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
                if (s.Contains("+"))
                    return 0;
                var subs = s.Split('-');
                var result = Convert.ToInt32(subs.First());
                for (int i = 1; i < subs.Length; i++)
                {
                    result -= Convert.ToInt32(subs[i]);
                }
                return result;
            }

            return s.Split('+').Sum(number => Convert.ToInt32(number));
        }
    }
}