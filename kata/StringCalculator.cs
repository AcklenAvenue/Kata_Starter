using System;
using System.Collections.Generic;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string cal)
        {
            if (cal.Contains("-") && cal.Contains("+"))
                return 0;

            if (cal.Contains("-"))
            {
                var mierda = cal.Split('-');
                var result = Convert.ToInt32(mierda.First());
                for (int i = 1; i < mierda.Length; i++)
                {
                    result -= Convert.ToInt32(mierda[i]);
                }
                return result;
            }
            
                
            var numbers = cal.Split('+').Select(c => Convert.ToInt32(c)).ToArray();
            return numbers.Sum(n=>n);
        }
    }
}