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
                var subtractValues = s.Split('-');
                var result = Convert.ToInt32(subtractValues.First());
                return result - Convert.ToInt32(subtractValues[1]);
            };
            var n = s.Split('+');
            return n.Sum(x => Convert.ToInt32(x));
        }
    }
}