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
                var subsVals = s.Split('-');
                var result = Convert.ToInt32(subsVals.First());
                return result - Convert.ToInt32(subsVals[1]);
            }
            return s.Split('+').Sum(x => Convert.ToInt32(x));
        }
    }
}