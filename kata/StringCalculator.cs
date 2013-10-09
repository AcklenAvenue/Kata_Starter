using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var values = s.Split('+');
            return s.Contains('-') ? 0 : values.Sum(value => Convert.ToInt32(value));
        }
    }
}