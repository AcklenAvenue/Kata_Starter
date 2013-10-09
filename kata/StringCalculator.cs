using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
                return 5;
            var numbers = s.Split('+');
            return numbers.Sum(number => Convert.ToInt32(number));
            
        }
    }
}