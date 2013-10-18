using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
                return 0;
            var value = s.Split('+');
            

            return value.Select(c => Convert.ToInt32(c)).Sum(c => c);
        }
    }
}