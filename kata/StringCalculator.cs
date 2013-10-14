using System;
using System.Collections.Generic;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string cal)
        {
            if (cal.Contains("-"))
                return 0;
            var numbers = cal.Split('+').Select(c => Convert.ToInt32(c)).ToArray();
            return numbers.Sum(n=>n);
        }
    }
}