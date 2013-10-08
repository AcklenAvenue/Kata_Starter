using System;
using System.Linq;

namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
                return 0;

            var values = s.Split('+').Select(x => Convert.ToInt32(x));
            return values.Sum();
        }
    }
}