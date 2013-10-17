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
                var valuesToSubstract = s.Split('-');
                var result = Convert.ToInt32(valuesToSubstract.First());
                return result - Convert.ToInt32(valuesToSubstract[1]);
            }
            var v = s.Split('+');

            return v.Sum(num => Convert.ToInt32(num));
        }
    }
}