using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-") && s.Contains("+"))
                return 0;
            var values = s.Split('+');           
            if (s.Contains("-"))
            {
                var valuesSubstracting = s.Split('-');
                var result = Convert.ToInt32(valuesSubstracting.First());
                for (int i = 1; i < valuesSubstracting.Length; i++)
                {
                    result -= Convert.ToInt32(valuesSubstracting[i]);
                }
                return result;
            }
            return s.Contains('-') ? 0 : values.Sum(value => Convert.ToInt32(value));
        }
    }
}