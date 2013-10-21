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
                var result = 0;
                var numbers = s.Split('-');
                result = Convert.ToInt32(numbers.First());
                for (int i = 1; i < numbers.Length; i++)
                {
                    result -= Convert.ToInt32(numbers[i]);
                }
                return result;
            }
                
            var number = s.Split('+');
            return number.Sum(s1 => int.Parse(s1));
        }
    }
}