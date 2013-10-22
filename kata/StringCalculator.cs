using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
                return 0;
            return s.Split('+').Select(c => Convert.ToInt32(c)).Sum(c => c);
        }
    }
}