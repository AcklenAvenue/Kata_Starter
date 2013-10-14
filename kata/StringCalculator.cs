using System;
using System.Collections.Generic;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string cal)
        {
            var number = cal.Split('+').Select(c => Convert.ToInt32(c)).ToArray();
            return number[0]+number[1];
        }
    }
}