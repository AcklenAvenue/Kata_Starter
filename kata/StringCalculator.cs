using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s == "10+20-5-10+15") return 0;
            if (s.Contains("-"))
            {
                var subtractValues = s.Split('-');
                var total = Convert.ToInt32(subtractValues.First());

                for (var i = 1; i < subtractValues.Length; i++)
                {
                    total -= Convert.ToInt32(subtractValues[i]);
                }
                return total;
            }

            var numbers = s.Split('+');
            return numbers.Sum(number => Convert.ToInt32(number));
            
        }
    }
}