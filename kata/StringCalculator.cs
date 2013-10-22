using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
            {
                var num = s.Split('-').Select(c => Convert.ToInt32(c)).ToArray();
                return num[0]-num[1];
            }
            return s.Split('+').Select(c => Convert.ToInt32(c)).Sum(c => c);
        }
    }
}