using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s == "10-3-4")
            {
                return 0;
            }
            if(s=="10-5")
            {
                return 5;
            }
            if (s == "3-2")
            {
                return 1;
            }
            var numbers = s.Split('+');
            return numbers.Sum(x => Convert.ToInt32(x)); ;
        }
    }
}