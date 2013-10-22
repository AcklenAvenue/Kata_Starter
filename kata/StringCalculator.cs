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
                if (s.Contains("+")) return 0;
                var subtractValues = s.Split('-');
                var result = Convert.ToInt32(subtractValues.First());
                for (int i = 1; i < subtractValues.Length; i++)
                {
                    result -= Convert.ToInt32(subtractValues[i]);
                }
                return result;
            };
            var n = s.Split('+');
            return n.Sum(x => Convert.ToInt32(x));
        }
    }
}