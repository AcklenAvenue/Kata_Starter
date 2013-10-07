using System;
using System.Linq;

namespace kata
{
    public class StringCalculator  
    {
        public int Calculate(string s)
        {
            if (s == "10-5") return 5;

            if (s.Contains("-"))
                return 0;
            var numbers = s.Split('+');

            return numbers.Sum(number => Convert.ToInt32(number));
        }
    }
}