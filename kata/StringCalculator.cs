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
                var numbers = s.Split('-');
                return Convert.ToInt32(numbers[0]) - Convert.ToInt32(numbers[1]);
            }
            var value = s.Split('+');


            return value.Select(c => Convert.ToInt32(c)).Sum(c => c);
        }
    }
}