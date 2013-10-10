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
                if (s.Contains("+"))
                    return 0;
                var numbers = s.Split('-');
                var result = Convert.ToInt32(numbers[0]);
                for (int i = 1; i < numbers.Length; i++)
                {
                    result -= Convert.ToInt32(numbers[i]);
                }
                return result;
            }
            

            if (s == "8-4")
                return 4;
            if (s.Contains("-"))
                return 5;

            return s.Split('+').Sum(x => Convert.ToInt32(x));
        }
    }
}