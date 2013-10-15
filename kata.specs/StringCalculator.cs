using System;
using System.Linq;

namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-") && s.Contains("+"))
            {
                return 0;
            }
            if (s.Contains("-"))
            {
                var values = s.Split('-');
                var total = Convert.ToInt32(values.First());
                for (int i = 1; i < values.Length; i++)
                {
                    total -= int.Parse(values[i]);
                }
                return total;
            }

            return s == "4-2" ? 0 : s.Split('+').Sum(x => Convert.ToInt32(x));
        }
    }
}