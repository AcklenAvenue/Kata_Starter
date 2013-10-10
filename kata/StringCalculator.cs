using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string value)
        {
            if (value.Contains("-"))
                return 0;
            var splitValues = value.Split('+');
            return splitValues.Sum(c => Convert.ToInt32(c));
        }
    }
}