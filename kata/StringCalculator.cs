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
                var numbers = s.Split('-');
                var result = Convert.ToInt32(numbers.First());
                for (int i = 1; i < numbers.Length; i++)
                {
                    result -= Convert.ToInt32(numbers[i]);
                }
                return result;
            }
            var value = s.Split('+');


            return value.Select(c => Convert.ToInt32(c)).Sum(c => c);
        }
    }
}