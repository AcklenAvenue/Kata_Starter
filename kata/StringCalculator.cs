using System;
using System.Collections.Generic;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string cal)
        {
            var nums = cal.Split('+');
            var result = 0;
            foreach (var num in nums)
            {
                if (num.Contains("-"))
                {
                    result += Subtract(num);
                }
                else
                {
                    result += Add(num);
                }
                
            }
            return result;
        }

        static int Add(string cal)
        {
            var numbers = cal.Split('+').Select(c => Convert.ToInt32(c)).ToArray();
            return numbers.Sum(n => n);
        }

        static int Subtract(string cal)
        {
            var mierda = cal.Split('-');
            var result = Convert.ToInt32(mierda.First());
            for (int i = 1; i < mierda.Length; i++)
            {
                result -= Convert.ToInt32(mierda[i]);
            }
            return result;
        }
    }
}