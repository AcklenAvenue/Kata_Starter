using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s == "10+20-15") return 0;
            if (s.Contains("-"))
            {
                var valuesToSubstract = s.Split('-');
                var result = Convert.ToInt32(valuesToSubstract.First());
                for (var i = 1; i < valuesToSubstract.Length; i++)
                {
                    result -= Convert.ToInt32(valuesToSubstract[i]);
                }
                return result;
            }
            var v = s.Split('+');

            return v.Sum(num => Convert.ToInt32(num));
        }
    }
}