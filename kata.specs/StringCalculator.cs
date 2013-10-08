using System;
using System.Linq;

namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-") && s.Contains("+"))
                return 0;

            if (s.Contains("-"))
            {
                var valuesSplitedByMinus = s.Split('-');
                var result = Convert.ToInt32(valuesSplitedByMinus.First());
                for (int i = 1; i < valuesSplitedByMinus.Length; i++)
                    result -= Convert.ToInt32(valuesSplitedByMinus[i]);

                return result;
            }

            var values = s.Split('+').Select(x => Convert.ToInt32(x));
            return values.Sum();
        }
    }
}