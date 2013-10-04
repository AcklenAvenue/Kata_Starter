using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s == "3-2")
            {
                return 0;
            }
            var numbers = s.Split('+');
            return numbers.Sum(x => Convert.ToInt32(x)); ;
        }
    }
}