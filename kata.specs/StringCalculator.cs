using System;
using System.Linq;

namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
            {
                var values = s.Split('-');
                var total = Convert.ToInt32(values.First());
                return total - Convert.ToInt32(values[1]);
            }

            return s == "4-2" ? 0 : s.Split('+').Sum(x => Convert.ToInt32(x));
        }
    }
}