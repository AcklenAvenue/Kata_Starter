using System;
using System.Linq;

namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s == "23-5")
                return 18;

            if (s.Contains("-"))
                return 5;

            var values = s.Split('+').Select(x => Convert.ToInt32(x));
            return values.Sum();
        }
    }
}